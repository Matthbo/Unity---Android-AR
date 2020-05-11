using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObj : MonoBehaviour
{
    private float width;
    private float height;

    void Update()
    {
        /*transform.Rotate(Vector3.up, .5f);
        transform.Rotate(Vector3.right, .25f);*/
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 pos = touch.position;
                float xAngle = (pos.x - transform.position.x) /2f;
                float yAngle = (pos.y - transform.position.y) /2f;

                transform.Rotate(Vector3.down, xAngle*Mathf.Deg2Rad);
                transform.Rotate(Vector3.right, yAngle*Mathf.Deg2Rad);
            }
        }
    }
}
