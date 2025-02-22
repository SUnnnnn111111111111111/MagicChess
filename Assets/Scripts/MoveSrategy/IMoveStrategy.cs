
using System.Collections.Generic;
using UnityEngine;

public interface IMoveStrategy
{
    List<GameObject> GetAvailableMoves(GameObject currentCell);
}
