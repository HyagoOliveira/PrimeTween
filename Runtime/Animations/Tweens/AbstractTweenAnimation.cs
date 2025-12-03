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

        private void OnEnable() => Play();
    }
}