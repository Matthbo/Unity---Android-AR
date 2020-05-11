using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 mOffset;

    private Vector3 GetMouseWorldPos()
    {
        var currentCamera = Camera.main;
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = currentCamera.WorldToScreenPoint(gameObject.transform.position).z;

        return currentCamera.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDown()
    {
        mOffset = transform.position - GetMouseWorldPos();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }

    
}
