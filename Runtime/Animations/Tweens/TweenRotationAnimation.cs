using UnityEngine;

namespace PrimeTween
{
    public sealed class TweenRotationAnimation : AbstractTweenAnimation<Quaternion>
    {
        protected override Tween GetTweenAnimation() => Tween.Rotation(transform, settings);
    }
}