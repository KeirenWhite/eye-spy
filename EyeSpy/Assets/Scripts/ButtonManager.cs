using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;


[System.Serializable]

public class DisplayPair
{
    public Sprite[] itemIcon;
    public GameObject[] display;
    public Sprite[] correctItems;
    public string displayText;
}
public class ButtonManager : MonoBehaviour
{
    public Lives lives;
    private List<GameObject> itemSprites;
    public List<DisplayPair> spriteDisplayPairs;
    public int currentItem = 0;

    public GameObject GetDisplaySpriteForIcon(ClickItem icon)
    {
        Sprite clickedSprite = icon.GetComponent<Image>().sprite;

        foreach (var pair in spriteDisplayPairs)
        {

            if (pair.itemIcon[currentItem] == clickedSprite && clickedSprite == pair.correctItems[currentItem])
            {
                return pair.display[currentItem];
            }
            else if (pair.itemIcon[currentItem] != clickedSprite)
            {
                lives.currentLives--;
            }
            else
            {
                lives.currentLives--;
            }
        }

        return null;
    }






}

