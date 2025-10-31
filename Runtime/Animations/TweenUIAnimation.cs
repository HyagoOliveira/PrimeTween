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

        public override void PlayAnimation()
        {
            switch (type)
            {
                case AnchoredAnimationType.AnchoredPosition:
                    Tween.UIAnchoredPosition(target, settings);
                    break;
                case AnchoredAnimationType.SizeDelta:
                    Tween.UISizeDelta(target, settings);
                    break;
                default:
                    break;
            }
        }

        public enum AnchoredAnimationType
        {
            AnchoredPosition,
            SizeDelta,
        }
    }
}
