using UnityEngine;

namespace PrimeTween
{
    public abstract class AbstractCoreAnimation : AbstractAnimation
    {
        public bool useUnscaledTime;

        private void Update() => Play();

        protected float GetDeltaTime() => useUnscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
    }
}