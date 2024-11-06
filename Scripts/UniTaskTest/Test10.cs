using System.Collections;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System.Threading;

namespace Assets.Scripts.UniTaskTest
{
    public class Test10 : MonoBehaviour
    {

        // Use this for initialization
        async UniTaskVoid Start()
        {
            //オブジェクトが破棄されるときにTokenを発動
            //CancellationToken token = this.GetCancellationTokenOnDestroy();

            //2022以降でMonobehaviourにGetCancellationTokenOnDestroy()の代わりが追加された
            CancellationToken token = destroyCancellationToken;

            //Unityのゲームが終了されるときにキャンセルされる．（基本的にはUniTaskが自動的に削除はしてくれる）
            CancellationToken token2 = Application.exitCancellationToken;

            Debug.Log("コルーチンが開始されました。");

            // 1秒間待機
            await UniTask.Delay(1000);

            Debug.Log("1秒経過しました。");

            // ゲームオブジェクトを破壊！
            Destroy(this.gameObject);   //これでは止まらない


            // 1秒間待機
            //ここでトークンを受け取ってUniTaskを停止する
            await UniTask.Delay(1000, cancellationToken: token);

            //ここでトークンが発行されていたら停止
            if (token.IsCancellationRequested) return;

            Debug.Log("この行は実行されません。");
        }
    }
}