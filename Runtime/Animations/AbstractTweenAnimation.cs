using UnityEngine;

namespace PrimeTween
{
    /// <summary>
    /// Abstract Tween animation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractTweenAnimation<T> : MonoBehaviour where T : struct
    {
        [Tooltip("The Tween animation properties.")]
        public TweenSettings<T> settings;

        private void OnEnable() => PlayAnimation();

        /// <summary>
        /// Plays the Tween animation.
        /// </summary>
        public abstract void PlayAnimation();
    }
}