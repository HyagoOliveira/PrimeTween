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

        public override string ToString()
        {
            var hasIDentifier = !string.IsNullOrEmpty(identifier);
            return hasIDentifier ? identifier : base.ToString();
        }
    }
}