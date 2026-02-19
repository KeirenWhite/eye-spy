using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BabyScript : MonoBehaviour
{
    public int babyCounter = 1;
    public GameObject baby;
    public Sprite side1;
    public Sprite side2;
    public Sprite stomach;
    public Sprite back;
    public bool backCondition = false;
    public void OnBabyClick()
    {
        if(babyCounter < 4)
        {
            babyCounter++;
        }
        else
        {
            babyCounter -= 3;
        }
        
    }

    private void Update()
    {
        BabyFlipper();
    }

    public void BabyFlipper()
    {
        if (babyCounter == 1)
        {
            baby.GetComponent<Image>().sprite = side1;
            backCondition = false;
        }
        else if (babyCounter == 2)
        {
            baby.GetComponent<Image>().sprite = side2;
            backCondition = false;
        }
        else if(babyCounter == 3)
        {
            baby.GetComponent<Image>().sprite = stomach;
            backCondition = false;
        }
        else if (babyCounter == 4)
        {
            baby.GetComponent<Image>().sprite = back;
            backCondition = true;
            Debug.Log("TRUUEEE");
        }
    }
}
