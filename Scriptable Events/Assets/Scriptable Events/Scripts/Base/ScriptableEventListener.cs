using UnityEngine;
using UnityEngine.Events;

namespace GameDevToolbelt
{
    public class ScriptableEventListener : MonoBehaviour
    {
        [SerializeField] private ScriptableEvent scriptableEvent;
        [SerializeField] private UnityEvent listeners;

        private void OnEnable()
        {
            scriptableEvent.Subscribe(OnEventTrigger);
        }

        private void OnDisable()
        {
            scriptableEvent.Unsubscribe(OnEventTrigger);
        }

        void OnEventTrigger()
        {
            listeners.Invoke();
        }
    }

    public abstract class ScriptableEventListener<S, T, P> : MonoBehaviour
        where S : ScriptableEvent<T, P> where T : UnityEvent<P>
    {
        [SerializeField] protected S scriptableEvent;
        [SerializeField] private T listeners;

        private void OnEnable()
        {
            scriptableEvent.Subscribe(OnEventTrigger);
        }

        private void OnDisable()
        {
            scriptableEvent.Unsubscribe(OnEventTrigger);
        }

        void OnEventTrigger(P arg)
        {
            listeners.Invoke(arg);
        }
    }
}
