using System.Collections;
using UnityEngine;

namespace Coroutine
{
    public class Test1 : MonoBehaviour
    {
        private void Start()
        {
            // コルーチンの実行
            StartCoroutine(Marcy());
        }

        // コルーチン
        private IEnumerator Marcy()
        {
            // ここに処理を書く

            // 3秒停止
            yield return new WaitForSeconds(3);

            // ここに再開後の処理を書く
        }
    }
}