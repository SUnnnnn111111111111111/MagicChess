using UnityEngine;
using UltEvents;

[CreateAssetMenu(fileName = "GlobalGameObjectStorage", menuName = "ScriptableObjects/GlobalGameObjectStorage", order = 1)]
public class GlobalGameObjectStorage : ScriptableObject
{
    [SerializeField] GameObject gameObject;
    [SerializeField] private UltEvent<GameObject> BeforeSet;
    [SerializeField] private UltEvent<GameObject> AfterSet;

    public GameObject GameObject
    {
        get => gameObject;

        set 
        {
            BeforeSet.Invoke(gameObject);
            gameObject = value;
            AfterSet.Invoke(gameObject);
        }
    }
}
