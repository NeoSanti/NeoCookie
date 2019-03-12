using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public TMPro.TextMeshProUGUI counter;
    public float currentBase;
    public float currentMultiplier;
    public float currentNumber;

    public float AddNumber
    {
        get
        {
            return (currentBase * currentMultiplier);
        }
    }

    public void BuyUpgrade(Upgrade Upgrade)
    {
        if (currentNumber >= Upgrade.upgradeCost) //Nos aseguramos de que se pueda comprar el update
        {
            currentNumber -= Upgrade.upgradeCost; //Le restamos el coste
            currentMultiplier = Upgrade.upgradeMultiplier;
            Upgrade.DisableUpgrade();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentNumber = 0; //Empezamos con 0 en el contador
        currentMultiplier = 1;
        currentBase = 1;
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = currentNumber + " cookies";
    }
}
