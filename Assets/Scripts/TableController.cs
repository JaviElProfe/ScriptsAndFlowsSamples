using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TableController : MonoBehaviour, IPointerClickHandler
{
    public GameObject objectToLaunch;
    public void OnPointerClick(PointerEventData data) {
        Debug.Log(GameBall.currentBall.name);
        GameObject.Destroy(GameBall.currentBall);
        GameBall.isLaunched = false;
        Instantiate(objectToLaunch);
    }
}
