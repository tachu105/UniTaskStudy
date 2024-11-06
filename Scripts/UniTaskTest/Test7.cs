using System.Collections;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System;

namespace Assets.Scripts.UniTaskTest
{
    public class Test7 : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
            // AsyncMarcyのインスタンスの生成
            AsyncMarcy asyncMarcy = new AsyncMarcy(17);
        }
    }

    public class AsyncMarcy
    {
        public int age { get; private set; }

        public AsyncMarcy(int age)
        {
            this.age = age;

            Marcy().Forget();
        }

        async UniTask Marcy()
        {
            await UniTask.Delay(TimeSpan.FromSeconds(2));
            Debug.Log($"マーシーは{age}歳です。");
        }
    }
}