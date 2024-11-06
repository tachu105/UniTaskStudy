using System.Collections;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System.Xml.Serialization;
using System;
using UnityEngine.SceneManagement;
using Unity.VisualScripting.Antlr3.Runtime;

namespace UniTaskTest
{
    public class Test3 : MonoBehaviour
    {

        private void Start()
        {
            SceneLoading().Forget();

            UniTask.Void(async (Token) =>
            {
                Debug.Log("シーンロード開始");
                await SceneManager.LoadSceneAsync("GameScene", LoadSceneMode.Additive).WithCancellation(Token);
                Debug.Log("シーンロード完了");
            }, destroyCancellationToken);
        }

        private async UniTask SceneLoading()
        {
            Debug.Log("シーンロード開始");
            await SceneManager.LoadSceneAsync("GameScene", LoadSceneMode.Additive);
            Debug.Log("シーンロード完了");
        }
    }
}