using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    private Rigidbody rigidB;

    private void Awake()
    {
        rigidB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(transform.position.y > 0.3f)
        {
            rigidB.MovePosition(new Vector3(transform.position.x, 0.3f, transform.position.z));
        }
    }
}
