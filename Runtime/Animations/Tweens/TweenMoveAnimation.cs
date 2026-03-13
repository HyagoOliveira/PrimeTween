using UnityEngine;

namespace PrimeTween
{
    public sealed class TweenMoveAnimation : AbstractTweenAnimation<Vector3>
    {
        private void Reset()
        {
            settings.startValue = transform.localPosition;
            settings.endValue = transform.localPosition + Vector3.up;
        }

        protected override Tween GetTweenAnimation() => Tween.LocalPosition(transform, settings);
    }
}