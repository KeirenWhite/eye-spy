using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Checklist : MonoBehaviour
{
    public ButtonManager buttonManager;

    public GameObject check1;
    public GameObject check2;
    public GameObject check3;
    public GameObject check4;
    public GameObject check5;
    public GameObject check6;

    private void Update()
    {
        Checkmarks();
    }

    private void Checkmarks()
    {
        if (buttonManager.currentItem == 1)
        {
            check1.SetActive(true);
        }
        if (buttonManager.currentItem == 2)
        {
            check2.SetActive(true);
        }
        if (buttonManager.currentItem == 3)
        {
            check3.SetActive(true);
        }
        if (buttonManager.currentItem == 4)
        {
            check4.SetActive(true);
        }
        if (buttonManager.currentItem == 5)
        {
            check5.SetActive(true);
        }
        if (buttonManager.currentItem == 6)
        {
            check6.SetActive(true);
        }
    }
}
