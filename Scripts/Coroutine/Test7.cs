using System.Collections;
using UnityEngine;

namespace Coroutine
{
    public class Test7 : MonoBehaviour
    {
        private void Start()
        {
            // AsyncMarcyのインスタンスの生成
            AsyncMarcy asyncMarcy = new AsyncMarcy(17, this);
        }
    }

    public class AsyncMarcy
    {
        public int age { get; private set; }

        public MonoBehaviour monoBehaviour { get; private set; }

        // コンストラクタ
        public AsyncMarcy(int age, MonoBehaviour monoBehaviour)
        {
            // 初期化
            this.age = age;
            this.monoBehaviour = monoBehaviour;

            // コルーチンの実行
            monoBehaviour.StartCoroutine(Marcy());
            // StartCoroutine(Marcy()); // これは動かない
        }

        IEnumerator Marcy()
        {
            yield return new WaitForSeconds(2);

            Debug.Log($"マーシーは{age}歳です。");
        }
    }
}