using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvestClick : MonoBehaviour {
    public GameObject prefab;
    public Camera cam;

	void Update () {

       PositionMouse();

       if (Input.GetMouseButtonDown(0))
       {
            Vector3 positionThing = cam.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(prefab, new Vector2(positionThing.x, positionThing.y), Quaternion.identity);
       }
	}

    void PositionMouse()
    {
        Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(mousePos.x, mousePos.y, 10);
    }

    void Oncolli
    {
        Debug.Log(other.gameObject.tag);
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.tag);
    }
}