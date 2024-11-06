using System;
using System.Collections;
using UnityEngine;

namespace Coroutine
{
    public class Test6 : MonoBehaviour
    {
        // プレファブ
        private GameObject prefab = null;

        private void Start()
        {
            // プログラムからプレファブをロードして取得する
            StartCoroutine(LoadAsync("bullet", obj => prefab = obj));
        }

        // Resourcesフォルダ下に配置されたプレファブを動的にロードする
        private IEnumerator LoadAsync(string filePath, Action<GameObject> callback)
        {
            // 非同期ロード開始
            ResourceRequest resourceRequest = Resources.LoadAsync<GameObject>(filePath);

            // ロードが終わるまで待機
            while(!resourceRequest.isDone)
            {
                yield return null;
            }

            // ロード完了、resourceRequest.assetからロードしたアセットを取得
            GameObject asset = resourceRequest.asset as GameObject;
            // ロードしたGameObject型のアセットを引数に設定してコールバックを起動
            callback.Invoke(asset);
        }
    }
}