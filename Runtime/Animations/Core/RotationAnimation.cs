using UnityEngine;

namespace PrimeTween
{
    [DisallowMultipleComponent]
    public sealed class RotationAnimation : AbstractCoreAnimation
    {
        public Space relation = Space.Self;
        public Vector3 speed = Vector3.up * 15f;

        public override void PlayAnimation()
        {
            var velocity = speed * GetDeltaTime();
            transform.Rotate(velocity, relation);
        }
    }
}