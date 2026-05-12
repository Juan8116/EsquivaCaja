using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TiempoManager : MonoBehaviour
{   
     public TextMeshProUGUI tiempoText;
    float tiempoTranscurrido = 0f;
    bool corriendo = true;

    void Update()
    {
        if (!corriendo) return;

        tiempoTranscurrido += Time.deltaTime;
        tiempoText.text = tiempoTranscurrido.ToString("F2") + "s";
    }

    public void PausarTiempo()
    {
        corriendo = false;
    }

    public void ReiniciarTiempo()
    {
        tiempoTranscurrido = 0f;
        corriendo = true;
    }
}
