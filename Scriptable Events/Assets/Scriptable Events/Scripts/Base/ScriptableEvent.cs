using UnityEngine;
using UnityEngine.Events;

namespace GameDevToolbelt
{
    [CreateAssetMenu(menuName = "Scriptable Events/Scriptable Event")]
    public class ScriptableEvent : ScriptableObject
    {
        [SerializeField] private UnityEvent _event;

        public void Subscribe(UnityAction action)
        {
            _event.AddListener(action);
        }

        public void Unsubscribe(UnityAction action)
        {
            _event.RemoveListener(action);
        }

        public void TriggerEvent()
        {
            _event.Invoke();
        }
    }

    public abstract class ScriptableEvent<T, P> : ScriptableObject where T : UnityEvent<P>
    {
        [SerializeField] private T _event;

        public void Subscribe(UnityAction<P> action)
        {
            _event.AddListener(action);
        }

        public void Unsubscribe(UnityAction<P> action)
        {
            _event.RemoveListener(action);
        }

        public void TriggerEvent(P arg)
        {
            _event.Invoke(arg);
        }
    }
}

