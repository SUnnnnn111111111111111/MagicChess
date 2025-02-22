// public class BishopMoveStrategy : IMoveStrategy
// {
//     private static readonly Vector2Int[] directions = 
//     {
//         new Vector2Int(-1, -1), new Vector2Int(1, -1),
//         new Vector2Int(-1,  1), new Vector2Int(1,  1)
//     };

//     public List<ChessCell> GetAvailableMoves(ChessCell currentCell)
//     {
//         List<ChessCell> availableCells = new List<ChessCell>();

//         foreach (var dir in directions)
//         {
//             ChessCell nextCell = currentCell;
//             while (true)
//             {
//                 nextCell = nextCell.GetNeighbor(dir);
//                 if (nextCell == null) break; // Вышли за границы доски
//                 availableCells.Add(nextCell);
//                 if (nextCell.IsOccupied()) break; // Встретили фигуру — останавливаемся
//             }
//         }
//         return availableCells;
//     }
// }
