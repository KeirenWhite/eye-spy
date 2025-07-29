using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClickItem : MonoBehaviour
{
    public ButtonManager buttonManager;
    public Display display;
    public void OnItemClick()
    {
        //Debug.Log("click");
        GameObject displaySprite = buttonManager.GetDisplaySpriteForIcon(this);

        
        displaySprite.SetActive(true);
        buttonManager.currentItem++;


    }
}
