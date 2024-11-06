using System;
using UnityEngine;
using Cysharp.Threading.Tasks;

namespace UniTaskTest
{
    public class Test1 : MonoBehaviour
    {
        private void Start()
        {
            // UniTaskの実行
            Marcy().Forget();

            // この書き方も間違いではないが非推奨扱いで、警告みたいなのが出てくる
            // Marcy();
        }

        // UniTask
        private async UniTask Marcy()
        {
            // ここに処理を書く

            // 3秒停止
            await UniTask.Delay(TimeSpan.FromSeconds(3));

            // ここに再開後の処理を書く
        }
    /*
        private async void Marcy2()
        {
            // voidにしてしまうとC#ネイティブの非同期処理（Task）を使用してしまう
            // TaskはUnityと非常に相性が悪い
        }
    */
    }
}