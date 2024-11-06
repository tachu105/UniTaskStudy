using System.Collections;
using UnityEngine;

namespace Coroutine
{
    public class Test10 : MonoBehaviour
    {
        private IEnumerator Start()
        {
            Debug.Log("コルーチンが開始されました。");

            // 1秒間待機
            yield return new WaitForSeconds(1.0f);

            Debug.Log("1秒経過しました。");

            // ゲームオブジェクトを破壊！
            Destroy(this.gameObject);

            // 1秒間待機
            yield return new WaitForSeconds(1.0f);

            Debug.Log("この行は実行されません。");
        }
    }
}