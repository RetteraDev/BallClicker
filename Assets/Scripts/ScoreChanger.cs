using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreChanger : MonoBehaviour
{
    int score;
    int combo;
    public TextMeshProUGUI ScoreText;

    void OnEnable() {
        OrbDestroyer.OnOrbClick += OrbHit;
        OrbDestroyer.OnOrbMiss += OrbMiss;
    }

    void OnDisable() {
        OrbDestroyer.OnOrbClick -= OrbHit;
        OrbDestroyer.OnOrbMiss -= OrbMiss;
    }

    void OrbHit() {
        score += ++combo;
        SetText();
    }

    void OrbMiss() {
        combo = 0;
        SetText();
    }

    void SetText () {
        ScoreText.text = String.Format(
            "Score: {0}\nCombo: {1}x",
            score,
            combo
        );
    }
}
