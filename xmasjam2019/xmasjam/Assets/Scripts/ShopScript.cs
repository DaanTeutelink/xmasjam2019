using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ShopScript : MonoBehaviour
{
    public Text shopButtonText;
    public Text moneyText;
    public GameObject shopWindow;
    bool isWindowOpen;
    int money;

    void Start()
    {
        isWindowOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        updateMoney();
    }

    void updateMoney()
    {
        moneyText.text = "Money: " + money.ToString("00000");
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
