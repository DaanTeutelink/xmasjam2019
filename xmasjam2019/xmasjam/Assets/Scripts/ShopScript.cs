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

        if (Input.GetKey(KeyCode.Space))
        {
            if (money < 9999)
            money = money + 5;

            if (money > 9999)
                money = 9999;
        }

    }

    void updateMoney()
    {
        moneyText.text = "Money: " + money.ToString("0000");
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
