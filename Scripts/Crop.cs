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
        if (currentDay < maxDays)
        {
            currentDay++;
        }
        else
        {
            canHarvest = true;
            UnsuscribeEvent();

        }
    }

    void Harvest()
    {
        Destroy(this.gameObject);
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
    public int MaxDays
    {
        get
        {
            return maxDays;
        }
    }

    public bool CanHarvest
    {
        get
        {
            return canHarvest;
        }
    }

    void UnsuscribeEvent()
    {
        EventsManager.UnsubscribeToEvent(EventType.GP_EndDay, GrownUp);
        EventsManager.UnsubscribeToEvent(EventType.GP_EndDay, GrownUp);
    }
}
