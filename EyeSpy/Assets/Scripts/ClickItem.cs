using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClickItem : MonoBehaviour
{
    public ButtonManager buttonManager;
    public ItemCounter itemCounter;
    public Display display;
    public GameObject grayBox;
    public void OnItemClick()
    {
        //Debug.Log("click");
        GameObject displaySprite = buttonManager.GetDisplaySpriteForIcon(this);
        GameObject checklist = buttonManager.GetChecklist(this);
        
        displaySprite.SetActive(true);
        grayBox.SetActive(true);
        itemCounter.itemCounter--;
        //checklist.SetActive(true);
        //buttonManager.currentItem++;


    }
}
