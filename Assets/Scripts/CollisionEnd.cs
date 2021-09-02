using UnityEngine;

namespace Assets.Scripts
{
    class CollisionEnd : MonoBehaviour
    {
        private TimerController timerController;

        private void Awake()
        {
            timerController = GameObject.Find("Player").GetComponent<TimerController>();
        }

        private void OnTriggerEnter(Collider other)
        {
            timerController.changeStatusStopTimer();
        }
    }
}