using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public int currentLives = 3;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    private void Update()
    {
        Debug.Log(currentLives);
        LoseLife();
    }

    public void LoseLife()
    {
        if (currentLives == 2)
        {
            life1.SetActive(false);
        }

        if (currentLives == 1)
        {
            life2.SetActive(false);
        }

        if (currentLives == 0)
        {
            life3.SetActive(false);
        }
    }
}
