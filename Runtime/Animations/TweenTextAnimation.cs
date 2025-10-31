using TMPro;
using UnityEngine;

namespace PrimeTween
{
    /// <summary>
    /// Tween animation for writing Text.
    /// </summary>
    [DisallowMultipleComponent]
    public sealed class TweenTextAnimation : AbstractTweenAnimation<int>
    {
        [Space]
        [SerializeField] private TMP_Text target;

        private void Reset() => target = GetComponentInChildren<TMP_Text>();

        public override void PlayAnimation()
        {
            settings.endValue = System.Math.Max(settings.endValue, target.text.Length);
            Tween.TextMaxVisibleCharacters(target, settings);
        }
    }
}