using UnityEngine;

namespace PrimeTween
{
    public abstract class AbstractCoreAnimation : AbstractAnimation
    {
        public bool useUnscaledTime;

        private void Update() => PlayAnimation();

        protected float GetDeltaTime() => useUnscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
    }
}