using UnityEngine;

namespace PrimeTween
{
    [DisallowMultipleComponent]
    public sealed class AnimationSequence : AbstractAnimation
    {
        [Tooltip("If enabled, each animation will play in parallel (in the same time)")]
        public bool playInParallel;

        [Space]
        public AbstractAnimation[] animations;

        public override void Stop()
        {
            foreach (var animation in animations)
            {
                animation.Stop();
            }
        }

        public override void Play()
        {
            foreach (var animation in animations)
            {
                animation.Play();
            }
        }

        public override async Awaitable PlayAsync()
        {
            if (playInParallel) await PlayParallelyAsync();
            else await PlayAndWaitAsync();
        }

        private async Awaitable PlayParallelyAsync()
        {
            Play(); // Plays all in parallel
            foreach (var animation in animations)
            {
                while (animation.IsPaying)
                    await Awaitable.NextFrameAsync();
            }
        }

        private async Awaitable PlayAndWaitAsync()
        {
            foreach (var animation in animations)
            {
                await animation.PlayAsync();
            }
        }
    }
}