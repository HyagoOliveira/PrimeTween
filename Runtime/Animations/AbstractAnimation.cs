using UnityEngine;

namespace PrimeTween
{
    public abstract class AbstractAnimation : MonoBehaviour
    {
        public string identifier = string.Empty;

        public bool IsPaying { get; protected set; }

        public abstract Awaitable PlayAsync();
        public virtual void Play() => IsPaying = true;
        public virtual void Stop() => IsPaying = false;
    }
}