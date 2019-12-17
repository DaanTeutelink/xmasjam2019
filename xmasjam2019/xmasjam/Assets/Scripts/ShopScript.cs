using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ShopScript : MonoBehaviour
{
    public Text shopButtonText;
    public GameObject shopWindow;
    bool isWindowOpen;

    void Start()
    {
        isWindowOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShopButton()
    {
        isWindowOpen = !isWindowOpen;
        shopWindow.SetActive(isWindowOpen);
        if (isWindowOpen)
        {
            shopButtonText.text = "Close";
        }
        else if (!isWindowOpen)
        {
            shopButtonText.text = "Shop";
        }


    }

}
