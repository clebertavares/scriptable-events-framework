using UnityEngine;
using GameDevToolbelt;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Scriptable Events/Primitives/Bool Event")]
public class BoolScriptableEvent : ScriptableEvent<BoolEvent,bool>
{

}

[System.Serializable]
public class BoolEvent : UnityEvent<bool>
{

}