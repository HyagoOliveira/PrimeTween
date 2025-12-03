using UnityEngine;

namespace PrimeTween
{
    /// <summary>
    /// Abstract Tween animation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractTweenAnimation<T> : AbstractAnimation where T : struct
    {
        [Tooltip("The Tween animation properties.")]
        public TweenSettings<T> settings;

        protected Tween tweenAnimation = default;

        private void OnEnable() => Play();

        public override void Play() => tweenAnimation = GetTweenAnimation();
        public override void Stop() => tweenAnimation.Stop();

        protected abstract Tween GetTweenAnimation();
    }
}