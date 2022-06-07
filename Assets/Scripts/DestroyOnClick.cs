using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DestroyOnClick : MonoBehaviour, IPointerClickHandler
{
    void Start() {
        
    }
    
    public void OnPointerClick(PointerEventData data)
    {
        Destroy(this.gameObject, 0); // Destroy this object after 0 seconds
    }

}
