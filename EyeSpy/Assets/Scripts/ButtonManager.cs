using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;


[System.Serializable]

public class DisplayPair
{
    public Sprite itemIcon;
    public GameObject display;
    public string displayText;
}
public class ButtonManager : MonoBehaviour
{    
    private List<GameObject> itemSprites;
    public List<DisplayPair> spriteDisplayPairs;

    public GameObject GetDisplaySpriteForIcon(ClickItem icon)
    {
        Sprite clickedSprite = icon.GetComponent<Image>().sprite;

        foreach (var pair in spriteDisplayPairs)
        {

            if (pair.itemIcon == clickedSprite)
            {

                return pair.display;
            }
        }

        return null;
    }






}

