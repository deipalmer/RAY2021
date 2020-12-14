using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using SimpleJSON;
using UnityEngine.UI;

public class GetInfo : MonoBehaviour
{
    public TextMeshProUGUI usuario;
    public TextMeshProUGUI nmonedas;
    public TextMeshProUGUI ncoronas;
    public TextMeshProUGUI nivel;
    public TextMeshProUGUI experienciarestante;
    public TextMeshProUGUI experiencia;
    public Slider sliderProgreso;



    void Awake()
    {
        StartCoroutine(GetText());
    }

    IEnumerator GetText()
    {
        UnityWebRequest datos = UnityWebRequest.Get("https://www.eliseomartinmora.com/ray/fall.php");
        yield return datos.SendWebRequest();
    
        if (datos.isNetworkError)
        {
            Debug.Log(datos.error);
        }

        else
        {
            //muestra resultado en pantalla
            Debug.Log(datos.downloadHandler.text);
            //Convierte la informacion del JSON
            JSONNode data = JSON.Parse(datos.downloadHandler.text);
            Debug.Log("Usuario: " + data["nick"]);
            Debug.Log("Nivel: " + data["level"]);
            Debug.Log("Monedas: " + data["coins"]);
            Debug.Log("Coronas: " + data["crowns"]);
            Debug.Log("Experiencia: " + data["progress"]);
            Debug.Log("Para el siguiente nivel: " + data["totalAmountForNextLevel"]);

            usuario.text = data["nick"];
            nivel.text = data["level"];
            nmonedas.text = data["coins"];
            ncoronas.text = data["crowns"];
            experiencia.text = data["progress"];
            experienciarestante.text = "/" + data["totalAmountForNextLevel"];

            float progresoActual = data["progress"];
            float totalNivel = data["totalAmountForNextLevel"];

            sliderProgreso.value = progresoActual / totalNivel;

        }
    }

}
