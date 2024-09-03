using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI hun, MsgVitoria;
    public int restantes;
    void Start()
    {
        restantes = FindObjectsOfType<moeda>().Length;
        hun.text = $"moedas restantes: {restantes}";
    }

    public void Subtrairmoedas(int valor)
    {
        restantes = restantes - valor;
        if (restantes <= 0)
        {
            MsgVitoria.text = "PARABÉNS!!";
        }
    }
    
    void Update()
    {
        
    }
}
