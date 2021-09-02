using UnityEngine;

namespace Assets.Scripts
{
    class TimerController : MonoBehaviour
    {
        private TextMesh textTimer;
        private float timerSpeed = 1f;
        private float time = 0f;

        public enum timerState
        {
            Running, Stopped
        }
        public timerState state;

        private void Awake()
        {
            textTimer = GameObject.Find("Timer").GetComponent<TextMesh>();
            state = timerState.Running;
        }

        private void Update()
        {
            if (state == timerState.Running)
            {
                time += timerSpeed * Time.deltaTime;
                textTimer.text = time.ToString("0.##");
            }
        }

        public void changeStatusStopTimer()
        {
            state = timerState.Stopped;
        }
    }
}
