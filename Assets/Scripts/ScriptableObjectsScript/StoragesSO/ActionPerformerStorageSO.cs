using UnityEngine;
using UltEvents;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "GlobalActionPerformerStorageSO", menuName = "GlobalStorageSO/GlobalActionPerformerStorageSO")]
public class GlobalActionPerformerStorageSO : ScriptableObject
{
    [SerializeField] ActionPerformer actionPerformer;
    [SerializeField] private UltEvent<ActionPerformer> BeforeSet;
    [SerializeField] private UltEvent<ActionPerformer> AfterSet;

    public ActionPerformer GameObject
    {
        get => actionPerformer;

        set 
        {
            if(actionPerformer == value) return;

            if(actionPerformer) 
                BeforeSet.Invoke(actionPerformer);

            actionPerformer = value;

            if(actionPerformer) 
                AfterSet.Invoke(actionPerformer);
        }
    }
}
