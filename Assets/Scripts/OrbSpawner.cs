using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbSpawner : MonoBehaviour
{

    [SerializeField] GameObject[] orbs = new GameObject[3];
    [SerializeField] Camera _mainCam;

    Vector3 _screenBounds;
    float _screenBoundsX;
    float _screenBoundsY;

    void Start()
    {
        _screenBounds = _mainCam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        _screenBoundsX = Mathf.Abs(_screenBounds.x);
        _screenBoundsY = Mathf.Abs(_screenBounds.y);
        InvokeRepeating("SpawnOrb", 1f, Random.Range(0.7f, 1.2f));
    }

    void SpawnOrb()
    {
        Instantiate(
            orbs[Random.Range(0, 3)],
            new Vector3(Random.Range(_screenBoundsX, -_screenBoundsX), _screenBoundsY + 0.5f, 1),
            transform.rotation
        );
    }
}
