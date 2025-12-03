using UnityEngine;

namespace PrimeTween
{
    [DisallowMultipleComponent]
    public sealed class RotationAnimation : AbstractCoreAnimation
    {
        public Space relation = Space.Self;
        public Vector3 speed = Vector3.up * 15f;

        protected override void UpdateAnimation(float time)
        {
            var velocity = speed * time;
            transform.Rotate(velocity, relation);
        }
    }
}