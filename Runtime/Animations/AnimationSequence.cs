using UnityEngine;

namespace PrimeTween
{
    [DisallowMultipleComponent]
    public sealed class AnimationSequence : MonoBehaviour
    {
        private AbstractAnimation[] animations;

        private void Awake() => animations = GetComponentsInChildren<AbstractAnimation>();

        public void Play()
        {
            foreach (var animation in animations)
            {
                animation.Play();
            }
        }

        public void Stop()
        {
            foreach (var animation in animations)
            {
                animation.Stop();
            }
        }
    }
}