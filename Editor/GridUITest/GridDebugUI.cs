using Dave6.Foundation.Collections;
using UnityEngine;
using UnityEngine.UIElements;

namespace Dave6.FoundationEditor
{
    public class GridDebugUI : MonoBehaviour
    {
        VisualElement root;
        VisualElement curCell;


        [SerializeField] Vector2Int gridSize = new Vector2Int(4, 4);

        [SerializeField] float cellSize = 64f;


        void Awake()
        {
            var doc = GetComponent<UIDocument>();
            root = doc.rootVisualElement.Q<VisualElement>("root");

            DrawGrid(gridSize.x, gridSize.y);
        }

        void DrawGrid(int width, int height)
        {
            var grid = new VisualElement();
            grid.style.flexDirection = FlexDirection.Row;
            grid.style.flexWrap = Wrap.Wrap;
            grid.style.alignContent = Align.FlexStart;
            grid.style.width = width * cellSize;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    grid.Add(CreateCell(x, y));
                }
            }

            root.Add(grid);
        }

        VisualElement CreateCell(int x, int y)
        {
            var cell = new VisualElement();
            cell.style.width = cellSize;
            cell.style.height = cellSize;
            cell.style.borderBottomWidth = 1;
            cell.style.borderTopWidth = 1;
            cell.style.borderLeftWidth = 1;
            cell.style.borderRightWidth = 1;
            cell.style.borderBottomColor = Color.darkGray;
            cell.style.borderTopColor = Color.darkGray;
            cell.style.borderLeftColor = Color.darkGray;
            cell.style.borderRightColor = Color.darkGray;

            cell.userData = new GridCoord(x, y);

            cell.RegisterCallback<ClickEvent>(_ =>
            {
                if (curCell != null)
                {
                    curCell.style.backgroundColor = Color.clear;
                }
                curCell = cell;
                var coord = (GridCoord)cell.userData;
                Debug.Log($"Clicked Cell: {coord.x}, {coord.y}");
                SetOccupied(cell);
            });

            return cell;
        }
        void SetOccupied(VisualElement cell)
        {
            cell.style.backgroundColor = new Color(0.3f, 0.6f, 0.9f);
        }
    }
}
