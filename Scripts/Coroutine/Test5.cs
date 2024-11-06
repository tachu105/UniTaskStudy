using System.Collections;
using UnityEngine;

namespace Coroutine
{
    public class Test5 : MonoBehaviour
    {
        [SerializeField, Tooltip("キャラクターコントローラー")]
        private CharacterController characterController = null;

        [SerializeField, Tooltip("速度")]
        private float moveSpeed = 10.0f;

        private void Start()
        {
            // WMove関数の実行
            StartCoroutine(WMove());
        }

        // Wキーでのキー入力操作を制御する
        private IEnumerator WMove()
        {
            // Wキーが押されてなければ繰り返す
            while (!Input.GetKey(KeyCode.W))
            {
                // 1フレーム待機
                yield return null;
            }

            // 前方に動かす
            characterController.Move(transform.forward * moveSpeed * Time.deltaTime);
            // 次のフレームまで待機
            yield return null;

            // 再びWキー入力がされていれば動き続ける
            StartCoroutine(WMove());
        }
    }
}