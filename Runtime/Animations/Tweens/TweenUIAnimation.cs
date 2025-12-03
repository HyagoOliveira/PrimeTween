using UnityEngine;

namespace PrimeTween
{
    /// <summary>
    /// Tween animations for UI.
    /// </summary>
    [DisallowMultipleComponent]
    public sealed class TweenUIAnimation : AbstractTweenAnimation<Vector2>
    {
        public AnchoredAnimationType type;

        [Space]
        [SerializeField] private RectTransform target;

        private void Reset() => target = GetComponentInChildren<RectTransform>();

        protected override Tween GetTweenAnimation() => type switch
        {
            AnchoredAnimationType.AnchoredPosition => Tween.UIAnchoredPosition(target, settings),
            AnchoredAnimationType.SizeDelta => Tween.UISizeDelta(target, settings),
            _ => default
        };

        public enum AnchoredAnimationType
        {
            AnchoredPosition,
            SizeDelta,
        }
    }
}
