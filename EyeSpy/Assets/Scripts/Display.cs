using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Display : MonoBehaviour
{
    public Button closeButton;
    public GameObject grayBox;


    private void Update()
    {
        closeButton.onClick.AddListener(() => 
        {
            Debug.Log("click");
            grayBox.SetActive(false);
            this.gameObject.SetActive(false);
        });
    }
}
