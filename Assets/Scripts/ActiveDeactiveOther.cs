using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ActiveDeactiveOther : MonoBehaviour, IPointerClickHandler
{
    public GameObject objectToControl;

    void Start() {

    }


    public void OnPointerClick(PointerEventData data)
    {
        objectToControl.SetActive(!objectToControl.activeSelf);
    }

}
