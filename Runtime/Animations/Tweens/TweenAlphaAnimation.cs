using UnityEngine;

namespace PrimeTween
{
    /// <summary>
    /// Tween Alpha animation.
    /// </summary>
    [DisallowMultipleComponent]
    public sealed class TweenAlphaAnimation : AbstractTweenAnimation<float>
    {
        [Space]
        [SerializeField] private CanvasGroup canvasGroup;
        [SerializeField] private SpriteRenderer spriteRenderer;
#if UNITY_UGUI_INSTALLED
        [SerializeField] private UnityEngine.UI.Graphic graphic;
        [SerializeField] private UnityEngine.UI.Shadow shadow;
#endif
#if UI_ELEMENTS_MODULE_INSTALLED
        [SerializeField] private UnityEngine.UIElements.VisualElement visualElement;
#endif

        private void Reset()
        {
            canvasGroup = GetComponentInChildren<CanvasGroup>();
            spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        }

        protected override Tween GetTweenAnimation()
        {
            if (canvasGroup) return Tween.Alpha(canvasGroup, settings);
            if (spriteRenderer) return Tween.Alpha(spriteRenderer, settings);
#if UNITY_UGUI_INSTALLED
            if (graphic) return Tween.Alpha(graphic, settings);
            if (shadow) return Tween.Alpha(shadow, settings);
#endif
#if UI_ELEMENTS_MODULE_INSTALLED
            if (visualElement != null) return Tween.Alpha(visualElement, settings);
#endif
            return default;
        }
    }
}