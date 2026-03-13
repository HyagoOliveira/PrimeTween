using UnityEngine;

namespace PrimeTween
{
    public abstract class AbstractCoreAnimation : AbstractAnimation
    {
        public bool useUnscaledTime;

        private void Update() => UpdateAnimation(GetDeltaTime());

        public override void Play()
        {
            base.Play();
            enabled = true;
        }

        public override void Stop()
        {
            base.Stop();
            enabled = false;
        }

        public override async Awaitable PlayAsync()
        {
            await Awaitable.NextFrameAsync();
            Play();
        }

        protected abstract void UpdateAnimation(float time);
        private float GetDeltaTime() => useUnscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
    }
}