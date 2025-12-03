using UnityEngine;

namespace PrimeTween
{
    public abstract class AbstractAnimation : MonoBehaviour
    {
        private void OnEnable() => PlayAnimation();

        /// <summary>
        /// Plays the Tween animation.
        /// </summary>
        public abstract void PlayAnimation();
    }
}