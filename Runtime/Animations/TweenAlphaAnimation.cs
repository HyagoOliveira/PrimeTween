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

        public override void PlayAnimation()
        {
            if (canvasGroup) Tween.Alpha(canvasGroup, settings);
            if (spriteRenderer) Tween.Alpha(spriteRenderer, settings);
#if UNITY_UGUI_INSTALLED
            if (graphic) Tween.Alpha(graphic, settings);
            if (shadow) Tween.Alpha(shadow, settings);
#endif
#if UI_ELEMENTS_MODULE_INSTALLED
            if (visualElement != null) Tween.Alpha(visualElement, settings);
#endif
        }
    }
}