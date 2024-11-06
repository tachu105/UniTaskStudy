using System.Collections;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System;

namespace Assets.Scripts.UniTaskTest
{
    public class Test8 : MonoBehaviour
    {

        // Use this for initialization
        async UniTaskVoid Start()
        {
            Debug.Log("コルーチンが開始されました。");

            // 1秒間待機
            await UniTask.Delay(TimeSpan.FromSeconds(1));

            Debug.Log("1秒経過しました。");

            // UniTaskを終了
            return;

            Debug.Log("この行は実行されません。");
        }
    }
}