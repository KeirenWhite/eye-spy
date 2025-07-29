using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Display : MonoBehaviour
{
    public Button closeButton;


    private void Update()
    {
        closeButton.onClick.AddListener(() => 
        {
            Debug.Log("click");
            this.gameObject.SetActive(false);
        });
    }
}
