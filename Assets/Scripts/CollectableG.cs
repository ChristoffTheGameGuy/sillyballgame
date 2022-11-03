using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableG : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(10, 20, 2)* Time.deltaTime);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerControl")
        {
            Debug.Log("You got the coin!");
            Destroy(this.gameObject);
        }
    }
}
