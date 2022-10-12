using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbDestroyer : MonoBehaviour
{   
    Camera _mainCam;
    Vector3 _screenBounds;
    float _screenBoundsY;

    public static Action OnOrbClick;
    public static Action OnOrbMiss;
    
    void Start()
    {
        _mainCam = Camera.main;
        _screenBounds = _mainCam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        _screenBoundsY = Mathf.Abs(_screenBounds.y);
    }

    void OnMouseDown() 
    {
        OnOrbClick();
        Destroy(this.gameObject);
    }

    void CheckPosY()
    {
        if (transform.position.y < -_screenBoundsY - 0.5f) {
            OnOrbMiss();
            Destroy(this.gameObject);
        }
    }

    void FixedUpdate()
    {
        CheckPosY();
    }
}
