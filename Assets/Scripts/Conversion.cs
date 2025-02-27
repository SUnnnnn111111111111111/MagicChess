using UnityEngine;


public static class Conversion 
{
    public static Material GetMaterial(Object _object) => _object as Material;
    
    public static Vector3 GetVector3(ActionPerformer _object) => _object.transform.position;
}
