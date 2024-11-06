using System.Collections;
using UnityEngine;

namespace Coroutine
{
    public class Test9 : MonoBehaviour
    {
        private void Start()
        {
            IEnumerator coroutine = Marcy();
            StartCoroutine(coroutine);
            StopCoroutine(coroutine);
        }

        private IEnumerator Marcy()
        {
            Debug.Log("コルーチン開始");

            yield return new WaitForSeconds(3);

            Debug.Log("コルーチン終了");
        }
    }
}