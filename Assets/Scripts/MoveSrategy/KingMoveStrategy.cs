// public class KingMoveStrategy : IMoveStrategy
// {
//     private static readonly Vector2Int[] directions = 
//     {
//         new Vector2Int(-1, -1), new Vector2Int(0, -1), new Vector2Int(1, -1),
//         new Vector2Int(-1,  0),                      new Vector2Int(1,  0),
//         new Vector2Int(-1,  1), new Vector2Int(0,  1), new Vector2Int(1,  1)
//     };

//     public List<ChessCell> GetAvailableMoves(ChessCell currentCell)
//     {
//         List<ChessCell> availableCells = new List<ChessCell>();
//         foreach (var dir in directions)
//         {
//             ChessCell neighbor = currentCell.GetNeighbor(dir);
//             if (neighbor != null) availableCells.Add(neighbor);
//         }
//         return availableCells;
//     }
// }
