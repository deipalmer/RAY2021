using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{

    public static MoneyManager instance;
    public int monedas = 0;
    public int coronas = 0;
    public TextMeshProUGUI textoMonedas;
    public TextMeshProUGUI textoCoronas;
    void Awake()
    {
        if (MoneyManager.instance == null)
        {
            MoneyManager.instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void AddCoins(int amount)
    {
        monedas += amount;
        textoMonedas.text = monedas.ToString();
        textoCoronas.text = coronas.ToString();
    }

    public void ConsumeCoins(int amount)
    {
        if(monedas>=amount)
        {
            AddCoins -= amount;
        }

        else
    }


}
