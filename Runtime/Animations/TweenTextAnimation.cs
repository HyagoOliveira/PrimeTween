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
#if TEXT_MESH_PRO_INSTALLED
        [Space]
        [SerializeField] private TMP_Text target;
#endif

        private void Reset() => target = GetComponentInChildren<TMP_Text>();

        public override void PlayAnimation()
        {
#if TEXT_MESH_PRO_INSTALLED
            settings.endValue = System.Math.Max(settings.endValue, target.text.Length);

            target.ForceMeshUpdate();
            Tween.TextMaxVisibleCharacters(target, settings);
#endif
        }
    }
}