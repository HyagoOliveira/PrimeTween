using UnityEngine;

namespace PrimeTween
{
    public sealed class TweenScaleAnimation : AbstractTweenAnimation<Vector3>
    {
        private void Reset()
        {
            settings.startValue = Vector3.one;
            settings.endValue = Vector3.one;
        }

        protected override Tween GetTweenAnimation() => Tween.Scale(transform, settings);
    }
}