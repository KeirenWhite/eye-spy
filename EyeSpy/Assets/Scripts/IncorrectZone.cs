using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncorrectZone : MonoBehaviour
{
    public Lives lives;

    public void OnZoneClick()
    {
        lives.currentLives--;
    }
}
