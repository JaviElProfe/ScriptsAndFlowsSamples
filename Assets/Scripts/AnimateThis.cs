using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimateThis : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)) {
            this.GetComponent<Animator>().Play("Rotate");
        } else {
            this.GetComponent<Animator>().Play("Idle");
        }
    }

}
