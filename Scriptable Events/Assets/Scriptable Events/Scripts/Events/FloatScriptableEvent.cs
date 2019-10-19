using UnityEngine;
using GameDevToolbelt;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Scriptable Events/Primitives/Float Event")]
public class FloatScriptableEvent : ScriptableEvent<FloatEvent,float>
{

}

[System.Serializable]
public class FloatEvent : UnityEvent<float>
{

}
