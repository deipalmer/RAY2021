using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager instance;

    public int monedas;
    public int coronas;
    public TextMeshProUGUI textLabelCoins;
    public TextMeshProUGUI textLabelCoronas;
    public GameObject popupError;
    public GameObject popupConfirmacion;

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
        UpdateLabelMonedas();
    }

    public void AddCoronas(int amount)
    {
        coronas += amount;
        UpdateLabelCoronas();
    }

    public void ConsumeCoins(int amount)
    {

        if (monedas >= amount)
        {
            monedas -= amount;
            UpdateLabelMonedas();
        }
    }

    public void ConsumeCoronas(int amount)
    {
        if (coronas >= amount)
        {
            coronas -= amount;
            UpdateLabelCoronas();
        }
    }

    public void UpdateLabelMonedas()
    {
        textLabelCoins.text = monedas.ToString();
    }

    public void UpdateLabelCoronas()
    {
        textLabelCoronas.text = coronas.ToString();
    }

    public void CheckMoney(int amount)
    {

        if(amount <= monedas)
        {
            popupConfirmacion.SetActive(true);
        }
        else
        {
            popupError.SetActive(true);
        }

    }
    public void CheckCoronas(int amount)
    {

        if (amount <= coronas)
        {
            popupConfirmacion.SetActive(true);
        }
        else
        {
            popupError.SetActive(true);
        }

    }
}
