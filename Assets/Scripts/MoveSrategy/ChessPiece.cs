// public class ChessPiece : MonoBehaviour
// {
//     private IMoveStrategy moveStrategy;

//     public void SetMoveStrategy(IMoveStrategy strategy)
//     {
//         moveStrategy = strategy;
//     }

//     public void HighlightAvailableMoves()
//     {
//         if (moveStrategy == null) return;

//         ChessCell currentCell = GetCurrentCell();
//         List<ChessCell> availableCells = moveStrategy.GetAvailableMoves(currentCell);

//         foreach (var cell in availableCells)
//         {
//             cell.Highlight();
//         }
//     }
// }
