using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    [SerializeField]
    private int point;
    void Start()
    {
        point = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        point++;

    }
}
