using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject PlayerControl;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - PlayerControl.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = PlayerControl.transform.position + offset;
    }
}
