using UnityEngine;

namespace ScriptableObjectsScript
{
    [CreateAssetMenu(fileName = "ActionSO", menuName = "ActionSO/ActionSO")]
    public abstract class ActionSO : ScriptableObject
    {
    }

    public abstract class ActionSo<T> : ActionSO
    {
    }
}