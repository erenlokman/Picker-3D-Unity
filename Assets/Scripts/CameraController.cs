using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private GameObject picker;

    private void LateUpdate()
    {
        transform.position = new Vector3(picker.transform.position.x + 4, transform.position.y, transform.position.z);

    }
}
