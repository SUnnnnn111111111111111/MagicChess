using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NeighborSelectionSettings", menuName = "Chess/NeighborSelectionSettings")]
public class NeighborSelectionSettings : ScriptableObject
{
    public enum NeighborType
    {
        HorizontalVertical,
        Diagonal,
        KnightMove
    }
    
    [System.Serializable]
    public class NeighborRule
    {
        public NeighborType neighborType;
        public int maxDistance = 1; // Сколько клеток можно просматривать в заданном направлении
    }
    
    public List<NeighborRule> neighborRules = new List<NeighborRule>();
    
    public List<Vector2Int> GetOffsets()
    {
        List<Vector2Int> offsets = new List<Vector2Int>();
        
        foreach (var rule in neighborRules)
        {
            switch (rule.neighborType)
            {
                case NeighborType.HorizontalVertical:
                    for (int i = 1; i <= rule.maxDistance; i++)
                    {
                        offsets.Add(new Vector2Int(i, 0));
                        offsets.Add(new Vector2Int(-i, 0));
                        offsets.Add(new Vector2Int(0, i));
                        offsets.Add(new Vector2Int(0, -i));
                    }
                    break;
                
                case NeighborType.Diagonal:
                    for (int i = 1; i <= rule.maxDistance; i++)
                    {
                        offsets.Add(new Vector2Int(i, i));
                        offsets.Add(new Vector2Int(-i, -i));
                        offsets.Add(new Vector2Int(i, -i));
                        offsets.Add(new Vector2Int(-i, i));
                    }
                    break;
                
                case NeighborType.KnightMove:
                    offsets.Add(new Vector2Int(2, 1));
                    offsets.Add(new Vector2Int(2, -1));
                    offsets.Add(new Vector2Int(-2, 1));
                    offsets.Add(new Vector2Int(-2, -1));
                    offsets.Add(new Vector2Int(1, 2));
                    offsets.Add(new Vector2Int(1, -2));
                    offsets.Add(new Vector2Int(-1, 2));
                    offsets.Add(new Vector2Int(-1, -2));
                    break;
            }
        }
        
        return offsets;
    }
}