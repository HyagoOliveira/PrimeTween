using UnityEngine;

namespace PrimeTween
{
    /// <summary>
    /// Abstract Tween animation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractTweenAnimation<T> : AbstractAnimation where T : struct
    {
        [Tooltip("The Tween animation properties."), ContextMenuItem("Create Loop", nameof(SetLoop))]
        public TweenSettings<T> settings;

        protected Tween tweenAnimation = default;

        private void OnEnable() => Play();
        private void OnDisable() => Stop();

        public override void Play() => tweenAnimation = GetTweenAnimation();
        public override void Stop() => tweenAnimation.Stop();

        public void SetLoop(CycleMode loop = CycleMode.Yoyo)
        {
            settings.settings.cycles = -1;
            settings.settings.cycleMode = loop;

            if (Application.isPlaying) tweenAnimation.SetRemainingCycles(-1);
        }

        protected abstract Tween GetTweenAnimation();
    }
}