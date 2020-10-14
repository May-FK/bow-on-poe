using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour

{
    // When left mouse click
    private Vector3 mOffset;
    private float mZCoord;

    void OnMouseDown()

    {
        
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        // To implement mouse in the 3d world
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();

    }



    private Vector3 GetMouseAsWorldPoint()

    {
        // Pixel coordinates of mouse (x,y)
        // When left mouse is clicked....
        Vector3 mousePoint = Input.mousePosition;



        // z coordinate of game object on screen
        // this is how the mouse is interacted in 3D
        mousePoint.z = mZCoord;



        // Convert it to world point
        return Camera.main.ScreenToWorldPoint(mousePoint);

    }



    void OnMouseDrag()

    {
        // when object is dragged
        transform.position = GetMouseAsWorldPoint() + mOffset;

    }

}
