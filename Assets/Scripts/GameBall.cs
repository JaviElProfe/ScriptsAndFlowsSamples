using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameBall : MonoBehaviour, IPointerClickHandler
{
    public static bool isLaunched;
    public static GameObject currentBall;

    // Update is called once per frame
    void Update()
    {
        Vector3 camPosition = Camera.main.transform.position;
        Vector3 camFoward = Camera.main.transform.forward;

        if (!isLaunched)
        {
            this.transform.position = camPosition + (camFoward * 1.5f);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        currentBall = this.gameObject;
        isLaunched = true;
        this.GetComponent<Rigidbody>().useGravity = true;
        Vector3 camForward = Camera.main.transform.forward;
        Vector3 force = new Vector3(camForward.x * 1200, Mathf.Max(camForward.y, 0.1f) * 1200, camForward.z * 1200);
        this.GetComponent<Rigidbody>().AddForce(force);
    }


}
