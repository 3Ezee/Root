using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvestClick : MonoBehaviour {
    public GameObject prefab;
    public Camera cam;
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 positionThing = cam.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(prefab, new Vector2(positionThing.x, positionThing.y),Quaternion.identity);
            
        }
	}
}