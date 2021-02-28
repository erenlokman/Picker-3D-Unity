using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickerMovement : MonoBehaviour
{
    [SerializeField]
    private float velocity = 1f;

    private Rigidbody rigidB;
    private float objectZPosition;
    private float moveZ;
    
    
    private void Awake()
    {
        rigidB = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        objectZPosition = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
    }

    private void OnMouseDrag()
    {
        var mousePoint = Input.mousePosition;
        mousePoint.z = objectZPosition;
        moveZ = Camera.main.ScreenToWorldPoint(mousePoint).z;
    }

    void FixedUpdate()
    {
        var x = (velocity * Time.fixedDeltaTime) * -1;
        var newPosition = transform.position + new Vector3(x, 0, -1.89f);
        if (moveZ > 2.343f)
            newPosition.z = 2.343f;
        else if (moveZ < -2.248f)
            newPosition.z = -2.248f;
        else
            newPosition.z = moveZ;
        rigidB.MovePosition(newPosition);
        
    }
}
