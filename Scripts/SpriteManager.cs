using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour {

    Crop _crop;
    Animator _anim;

	void Start () {
        _crop = this.gameObject.GetComponent<Crop>();
        _anim = this.gameObject.GetComponent<Animator>();
        EventsManager.SubscribeToEvent(EventType.GP_EndDay, CheckSprite);
    }

    void CheckSprite(params object[] parameters)
    {

        if(_crop != null)
        {
            _anim.SetInteger("CurrentDay", _crop.CurrentDay);
        }

        if (_crop == null ||_crop.CanHarvest)
            EventsManager.UnsubscribeToEvent(EventType.GP_EndDay, CheckSprite);
        
    }
}
