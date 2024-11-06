using System.Collections;
using UnityEngine;
using Cysharp.Threading.Tasks;

namespace Assets.Scripts.UniTaskTest
{
    public class Test5 : MonoBehaviour
    {
        [SerializeField, Tooltip("キャラクターコントローラー")]
        private CharacterController characterController = null;

        [SerializeField, Tooltip("速度")]
        private float moveSpeed = 10.0f;

        // Use this for initialization
        void Start()
        {
            WMove().Forget();
        }

        async UniTaskVoid WMove()
        {
            while (!Input.GetKeyDown(KeyCode.W))
            {
                
                await UniTask.Yield(); 
                //await UniTask.DelayFrame(1); 1フレーム以上待機する場合はこっち
            }
            /*
             *while文の部分の別の書き方
             *書き方1
             *  await UniTask.WaitUntil(() => Input.GetKeyDown(KeyCode.W));
             *書き方2
             *  await UniTask.WaitWhile(() => !Input.GetKeyDown(KeyCode.W));
             */

            /*
             * 条件が2個ある場合
             *  await UniTask.WaitUntil(() => Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.S))
             */

            // 前方に動かす
            //characterController.Move(transform.forward * moveSpeed * Time.deltaTime);
            Debug.Log("OK");

            await UniTask.DelayFrame(1);

            WMove().Forget();
        }
    }
}