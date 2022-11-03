using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl2 : MonoBehaviour
{
    public GameObject PlayerControl2;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - PlayerControl2.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = PlayerControl2.transform.position + offset;
    }
}
