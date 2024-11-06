using System.Collections;
using UnityEngine;

namespace Coroutine
{
    public class Test2 : MonoBehaviour
    {
        private void Start()
        {
            // コルーチンの実行
            StartCoroutine(Marcy());

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