using UnityEngine;

namespace PrimeTween
{
    [DisallowMultipleComponent]
    public sealed class TweenRotationAnimation : AbstractTweenAnimation<Quaternion>
    {
        public override void PlayAnimation() => Tween.Rotation(transform, settings);
    }
}