using System.Collections;
using UnityEngine;

namespace Coroutine
{
    public class Test8 : MonoBehaviour
    {
        private IEnumerator Start()
        {
            Debug.Log("コルーチンが開始されました。");

            // 1秒間待機
            yield return new WaitForSeconds(1.0f);

            Debug.Log("1秒経過しました。");

            // コルーチンを終了
            yield break;

            Debug.Log("この行は実行されません。");
        }
    }
}