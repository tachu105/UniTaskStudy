using System.Collections;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System;

namespace Assets.Scripts.UniTaskTest
{
    public class Test6 : MonoBehaviour
    {
        private GameObject prefab = null;

        // Use this for initialization
        async UniTaskVoid Start()
        {
            //デリゲートを使う場合
            LoadAsync("bullet", obj => prefab = obj).Forget();
            
            //戻り値を使う場合
            prefab = await LoadAsync2("bullet");

            //直接awaitでResourcesを待機する
            prefab = await Resources.LoadAsync<GameObject>("bullet") as GameObject;
        }

        /// <summary>
        /// デリゲートを使用する場合
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        async UniTask LoadAsync(string filePath, Action<GameObject> callback)
        {
            ResourceRequest resourceRequest = Resources.LoadAsync<GameObject>(filePath);

            // ロードが終わるまで待機
            while (!resourceRequest.isDone)
            {
                await UniTask.Yield();
            }

            // ロード完了、resourceRequest.assetからロードしたアセットを取得
            GameObject asset = resourceRequest.asset as GameObject;
            // ロードしたGameObject型のアセットを引数に設定してコールバックを起動
            callback.Invoke(asset);
        }

        /// <summary>
        /// 戻り値を使用する場合
        /// </summary>
        /// <typeparam name="GameObject"></typeparam>
        /// <param name="filePath"></param>
        /// <returns></returns>
        async UniTask<GameObject> LoadAsync2(string filePath)
        {
            ResourceRequest resourceRequest = Resources.LoadAsync<GameObject>(filePath);

            // ロードが終わるまで待機
            while (!resourceRequest.isDone)
            {
                await UniTask.Yield();
            }

            // ロード完了、resourceRequest.assetからロードしたアセットを取得
            GameObject asset = resourceRequest.asset as GameObject;

            return asset;
        }
    }
}