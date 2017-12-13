using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crop : MonoBehaviour, iPutIneable {

    bool isWatered = false;
    bool canHarvest = false;
    public int maxDays;
    public int currentDay;
    
	void Start () {
        currentDay = 1;
        EventsManager.SubscribeToEvent(EventType.GP_EndDay, GrownUp);
    }

    public void PutIn(float x, float y)
    {
        this.transform.position = new Vector2(x, y);
    }

    void GrownUp(params object[] parameters)
    {
        currentDay++;
    }

    void Harvest()
    {
        UnsuscribeEvent();
    }

    void Die()
    {
        UnsuscribeEvent();
    }

    public int CurrentDay
    {
        get
        {
            return currentDay;
        }
    }

    void UnsuscribeEvent()
    {
        EventsManager.UnsubscribeToEvent(EventType.GP_EndDay, GrownUp);
        EventsManager.UnsubscribeToEvent(EventType.GP_EndDay, GrownUp);
    }
}
