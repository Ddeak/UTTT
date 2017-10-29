using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public Color color;
    public Location location;
    private Renderer rend;

    public enum Location {
        TopLeft,
        TopMiddle,
        TopRight,
        Left,
        Middle,
        Right,
        BottomLeft,
        BottomMiddle,
        BottomRight
    }

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnMouseUp()
    {
        rend.material.color = Color.blue;
    }
}
