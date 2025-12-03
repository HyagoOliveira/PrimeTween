using UnityEngine;

namespace PrimeTween
{
    public abstract class AbstractAnimation : MonoBehaviour
    {
        /// <summary>
        /// Plays the Tween animation.
        /// </summary>
        public abstract void Play();
    }
}