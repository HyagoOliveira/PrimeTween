using UnityEngine;

namespace PrimeTween
{
    public abstract class AbstractAnimation : MonoBehaviour
    {
        public abstract void Play();
        public abstract void Stop();
    }
}