using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndGame : MonoBehaviour
{
    public ItemCounter itemCounter;
    public BabyScript babyScript;

    public GameObject winEndDisplay;
    public GameObject loseEndDisplay;
    public GameObject bottomMenu;
    public GameObject restartButton;

    private void Update()
    {
        EndTheGame();
    }


    public void EndTheGame()
    {
        if (itemCounter.itemCounter == 0 && babyScript.backCondition == true)
        {
            Debug.Log("W");
            //winEndDisplay.SetActive(true);
            //bottomMenu.SetActive(false);
            //restartButton.SetActive(true);
        }

       /* if (lives.currentLives <= 0)
        {
            loseEndDisplay.SetActive(true);
            bottomMenu.SetActive(false);
            restartButton.SetActive(true);
        }*/
    }
}
