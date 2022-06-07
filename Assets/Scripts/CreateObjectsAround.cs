using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CreateObjectsAround : MonoBehaviour, IPointerClickHandler
{
 
    public GameObject objectToCreate;

    void Start() {
        
    }

    public void OnPointerClick(PointerEventData data)
    {
        float posX = Random.Range(-5.0f, 5.0f);
        float posZ = Random.Range(-5.0f, 5.0f);
        GameObject.Instantiate(objectToCreate, new Vector3(posX, 0, posZ), Quaternion.identity);
    }

}
