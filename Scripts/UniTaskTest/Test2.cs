using System;
using UnityEngine;
using Cysharp.Threading.Tasks;

namespace UniTaskTest
{
    public class Test2 : MonoBehaviour
    {
        private void Start()
        {
            // UniTaskの実行
            Marcy().Forget();

            Debug.Log("まどのゆき");
        }

        // UniTask
        private async UniTask Marcy()
        {
            Debug.Log("ほたるの");

            // 3秒停止
            await UniTask.Delay(TimeSpan.FromSeconds(3));

            Debug.Log("ひかり");
        }
    }
}