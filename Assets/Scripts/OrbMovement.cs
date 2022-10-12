using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbMovement : MonoBehaviour
{   
    Camera _mainCam;
    Vector3 _screenBounds;
    float _screenBoundsY;
    public float speed = 2;

    void Start()
    {
        _mainCam = Camera.main;
        _screenBounds = _mainCam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        _screenBoundsY = Mathf.Abs(_screenBounds.y);
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }
}
