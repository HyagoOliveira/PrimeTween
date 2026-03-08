using UnityEngine;

namespace PrimeTween
{
    [DisallowMultipleComponent]
    public sealed class AnimationSequence : AbstractAnimation
    {
        private AbstractAnimation[] animations;

        private void Awake() => animations = GetComponentsInChildren<AbstractAnimation>();

        public override async Awaitable PlayAsync()
        {
            foreach (var animation in animations)
            {
                await animation.PlayAsync();
            }
        }

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