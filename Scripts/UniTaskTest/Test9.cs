using System.Collections;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System;
using System.Threading;

namespace Assets.Scripts.UniTaskTest
{
    public class Test9 : MonoBehaviour
    {

        // Use this for initialization
        async void Start()
        {
            CancellationTokenSource cts = new CancellationTokenSource();

            Marcy(cts.Token).Forget();

            cts.Cancel();
            cts.Token.Register(() => { /*キャンセル後に行う処理*/});
        }

        async UniTask Marcy(CancellationToken token)
        {
            Debug.Log("コルーチン開始");

            //ここを実行中にCancelが呼ばれても削除されない
            await UniTask.Delay(TimeSpan.FromSeconds(3));

            //第~引数の値を直接指定することができる(～: 値)
            //tokenが渡されているところに来たら停止する（停止処理は残るため，上のDelay中にCancelされても，ここまでくれば自動的にキャンセルされる）
            await UniTask.Delay(TimeSpan.FromSeconds(3), cancellationToken: token);

            Debug.Log("コルーチン終了");
        }
    }
}