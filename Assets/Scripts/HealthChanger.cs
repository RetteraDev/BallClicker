using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthChanger : MonoBehaviour
{
    [SerializeField] GameObject[] _hearts = new GameObject[3];
    int _currentHearts = 2;

    void OnEnable()
    {
        OrbDestroyer.OnOrbMiss += DecreaseHealth;
    }

    void OnDisable()
    {
        OrbDestroyer.OnOrbMiss -= DecreaseHealth;
    }

    void DecreaseHealth() {
        Destroy(_hearts[_currentHearts].gameObject, 0);
        _currentHearts--;
        if (_currentHearts < 0)
            SceneManager.LoadScene(0);
    }
}
