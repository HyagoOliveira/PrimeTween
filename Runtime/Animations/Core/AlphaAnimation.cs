using UnityEngine;

namespace PrimeTween
{
    /// <summary>
    /// Alpha animation for the local UI Components.
    /// <para>
    /// Use the <see cref="opacityCurve"/> curve to animate the alpha from a UI component.
    /// </para>
    /// </summary>
    public sealed class AlphaAnimation : AbstractCoreAnimation
    {
        [Space]
        [SerializeField, Tooltip("The curve driving the opacity animation.")]
        private AnimationCurve opacityCurve;

        [Space]
        [SerializeField] private CanvasGroup canvasGroup;
        [SerializeField] private SpriteRenderer spriteRenderer;
#if UNITY_UGUI_INSTALLED
        [SerializeField] private UnityEngine.UI.Graphic graphic;
        [SerializeField] private UnityEngine.UI.Shadow shadow;
#endif

        public float CurrentTime { get; private set; }

        private void OnDisable() => Stop();

        public void SetOpacity(float opacity)
        {
            if (canvasGroup) canvasGroup.alpha = opacity;
            if (spriteRenderer) spriteRenderer.color = spriteRenderer.color.WithAlpha(opacity);
#if UNITY_UGUI_INSTALLED
            if (graphic) graphic.color = graphic.color.WithAlpha(opacity);
            if (shadow) shadow.effectColor = shadow.effectColor.WithAlpha(opacity);
#endif
        }

        protected override void UpdateAnimation(float time)
        {
            CurrentTime += time;
            var opacity = opacityCurve.Evaluate(CurrentTime);
            SetOpacity(opacity);
            CheckStopCondition();
        }

        public override void Stop()
        {
            base.Stop();
            CurrentTime = 0f;
        }

        private void CheckStopCondition()
        {
            if (HasCurveFinished(opacityCurve, CurrentTime)) Stop();
        }

        public static bool HasCurveFinished(AnimationCurve curve, float currentTime)
        {
            var isLoop = curve.postWrapMode is WrapMode.Loop or WrapMode.PingPong;
            if (isLoop) return false;
            return currentTime >= GetDuration(curve);
        }

        public static float GetDuration(AnimationCurve curve) => curve.keys.Length > 0 ? curve.keys[^1].time : 0f;
    }
}