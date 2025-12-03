using UnityEngine;

namespace PrimeTween
{
    public abstract class AbstractCoreAnimation : AbstractAnimation
    {
        public bool useUnscaledTime;

        private void Update() => UpdateAnimation(GetDeltaTime());

        public override void Play() => enabled = true;
        public override void Stop() => enabled = false;

        protected abstract void UpdateAnimation(float time);
        private float GetDeltaTime() => useUnscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
    }
}