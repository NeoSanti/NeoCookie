using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (Button))]
public class Upgrade : MonoBehaviour
{
    GameManager gm;
    Button button;
    public int upgradeMultiplier;
    public int upgradeCost;
    public string upgradeText;
    bool bought;

    public void Start()
    {
        gm = FindObjectOfType<GameManager>();
        button = GetComponent<Button>();
        button.interactable = false;
        bought = false;
        GetComponentInChildren<TMPro.TextMeshProUGUI>().text = upgradeText;
    }

    public void UpgradeMethod()
    {
        gm.BuyUpgrade(this);
    }

    public void DisableUpgrade()
    {
        button.interactable = false;
        bought = true;
    }

    public void Update()
    {
        if(!bought && gm.currentNumber >= upgradeCost)
        {
            button.interactable = true;
        }
    }
}
