using System.Collections;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System;
using Coroutine;
using Unity.VisualScripting.Dependencies.Sqlite;

namespace Assets.Scripts.UniTaskTest
{
    public class Test4 : MonoBehaviour
    {

        // UniTaskVoidは強制的にForgetさせる（awaitで処理終了を待つことはできない）
        private async UniTaskVoid Start()
        {
            await Marcy();

            // まどーのーゆーきー
            Debug.Log("まどのゆき");
        }

        //private async UniTaskVoid Marcy()　→　await Marcy()でエラーが起こる（Marcy().Forget()は行ける）
        private async UniTask Marcy()
        {
            // ほたーるのっ
            Debug.Log("ほたるの");

            // 2秒停止
            await UniTask.Delay(TimeSpan.FromSeconds(2));

            // ひーかーりっ
            Debug.Log("ひかり");
        }

    }
}