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
    public GameObject[] checklist;
    public Sprite[] correctItems;
    public string displayText;
}
public class ButtonManager : MonoBehaviour
{
    public Lives lives;
    private List<GameObject> itemSprites;
    public List<DisplayPair> spriteDisplayPairs;
    public int currentItem = 0;
    //public ItemCounter itemCounter;

    public GameObject GetDisplaySpriteForIcon(ClickItem icon)
    {
        Sprite clickedSprite = icon.GetComponent<Image>().sprite;

        foreach (var pair in spriteDisplayPairs)
        {
            for (int i = 0; i < pair.correctItems.Length; i++)
            {
                if (clickedSprite == pair.correctItems[i])
                {
                    //itemCounter.itemCounter--;
                    icon.gameObject.SetActive(false);
                    return pair.display[i];
                }
            }
        }

        
        return null;
    }

    public GameObject GetChecklist(ClickItem icon)
    {
        Sprite clickedSprite = icon.GetComponent<Image>().sprite;

        foreach (var pair in spriteDisplayPairs)
        {
            for (int i = 0; i < pair.itemIcon.Length; i++)
            {
                if (clickedSprite == pair.itemIcon[i] && clickedSprite == pair.correctItems[i])
                {
                    return pair.checklist[i];
                }
            }
        }

        return null;
    }






}

