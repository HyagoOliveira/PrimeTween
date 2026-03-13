using UnityEngine;

namespace PrimeTween
{
    public abstract class AbstractAnimation : MonoBehaviour
    {
        public string identifier = string.Empty;

        public abstract Awaitable PlayAsync();
        public abstract void Play();
        public abstract void Stop();
    }
}