using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndGame : MonoBehaviour
{
    public Lives lives;
    public ButtonManager buttonManager;

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
        if (buttonManager.currentItem >= 6)
        {
            winEndDisplay.SetActive(true);
            bottomMenu.SetActive(false);
            restartButton.SetActive(true);
        }

        if (lives.currentLives <= 0)
        {
            loseEndDisplay.SetActive(true);
            bottomMenu.SetActive(false);
            restartButton.SetActive(true);
        }
    }
}
