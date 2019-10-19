using UnityEngine;
using GameDevToolbelt;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Scriptable Events/Primitives/Int Event")]
public class IntScriptableEvent : ScriptableEvent<IntEvent,int>
{

}

[System.Serializable]
public class IntEvent : UnityEvent<int>
{

}