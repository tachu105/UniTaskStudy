using System.Collections;
using UnityEngine;

namespace Coroutine
{
    public class Test4 : MonoBehaviour
    {
        // Start関数をコルーチン化する
        private IEnumerator Start()
        {
            // Marcy関数の実行終了を待機
            yield return StartCoroutine(Marcy());

            // まどーのーゆーきー
            Debug.Log("まどのゆき");
        }

        // コルーチン
        private IEnumerator Marcy()
        {
            // ほたーるのっ
            Debug.Log("ほたるの");

            // 2秒停止
            yield return new WaitForSeconds(2);

            // ひーかーりっ
            Debug.Log("ひかり");
        }
    }
}