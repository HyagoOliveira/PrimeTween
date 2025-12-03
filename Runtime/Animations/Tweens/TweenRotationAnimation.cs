using UnityEngine;

namespace PrimeTween
{
    [DisallowMultipleComponent]
    public sealed class TweenRotationAnimation : AbstractTweenAnimation<Quaternion>
    {
        public override void Play() => Tween.Rotation(transform, settings);
    }
}