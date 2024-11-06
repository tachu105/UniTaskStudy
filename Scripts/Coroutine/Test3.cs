using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Coroutine
{
    public class Test3 : MonoBehaviour
    {
        IEnumerator SceneLoading()
        {
            Debug.Log("シーンロード開始");

            // 非同期でシーンをロードする
            yield return SceneManager.LoadSceneAsync("GameScene", LoadSceneMode.Additive);

            Debug.Log("シーンロード完了");
        }
    }
}