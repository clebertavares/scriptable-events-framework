using UnityEngine;
using GameDevToolbelt;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Scriptable Events/Primitives/String Event")]
public class StringScriptableEvent : ScriptableEvent<StringEvent,string>
{

}

[System.Serializable]
public class StringEvent : UnityEvent<string>
{

}