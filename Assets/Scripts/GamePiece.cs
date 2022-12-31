using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePiece : MonoBehaviour
{

    public int score;
    private int x;
    private int y;

    public int X 
    {
        get { return x; }
        set
        {
            if (isMovable())
            {
                x = value;
            }
        }
    }

    public int Y
    {
        get { return y; }
        set
        {
            if (isMovable())
            {
                y = value;
            }
        }
    }

    private GridController.PieceType type;

    public GridController.PieceType Type
    {
        get{ return type; }
    }

    private GridController grid;

    public GridController GridRef
    {
        get{ return grid; }
    }

    private MoveablePiece moveableComponent;

    public MoveablePiece MoveableComponent
    {
        get { return moveableComponent; }
    }

    private ColorPiece colorComponent;

    public ColorPiece ColorComponent
    {
        get { return colorComponent; }
    }
    
    private ClearablePiece clearableComponent;

    public ClearablePiece ClearableComponent
    {
        get { return clearableComponent; }
    }

    void Awake()
    {
        moveableComponent = GetComponent<MoveablePiece>();
        colorComponent = GetComponent<ColorPiece>();
        clearableComponent = GetComponent<ClearablePiece>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Init(int _x, int _y, GridController _grid, GridController.PieceType _type)
    {
        x = _x;
        y = _x;
        grid = _grid;
        type = _type;
    }

    void OnMouseEnter()
    {
        grid.EnteredPiece(this);
    }

    void OnMouseDown()
    {
        grid.PressedPiece(this);
    }

    void OnMouseUp()
    {
        grid.ReleasedPiece();
    }


    public bool isMovable()
    {
        return moveableComponent != null;
    }

    public bool isColored()
    {
        return colorComponent != null;
    }

    public bool isClearable()
    {
        return clearableComponent != null;
    }

}
