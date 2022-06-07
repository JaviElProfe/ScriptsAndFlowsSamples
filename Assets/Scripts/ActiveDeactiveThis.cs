using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveDeactiveThis : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.S)) {
            this.gameObject.SetActive(false);
        } else {
            this.gameObject.SetActive(true);
        }
    }

}
