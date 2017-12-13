using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDay : MonoBehaviour {

	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EventsManager.TriggerEvent(EventType.GP_EndDay);
        }
	}
}
