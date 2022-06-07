using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    private Vector3 InitialPosition;
    // Start is called before the first frame update
    void Start()
    {
        InitialPosition = this.transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Collisions")) {
            this.transform.position = InitialPosition;
        }
    }
}