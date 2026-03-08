using UnityEngine;

namespace PrimeTween
{
    [DisallowMultipleComponent]
    public sealed class AnimationSequence : AbstractAnimation
    {
        private AbstractAnimation[] animations;

        private void Awake() => animations = GetComponentsInChildren<AbstractAnimation>();

        public override void Play()
        {
            foreach (var animation in animations)
            {
                animation.Play();
            }
        }

        public override void Stop()
        {
            foreach (var animation in animations)
            {
                animation.Stop();
            }
        }
    }
}