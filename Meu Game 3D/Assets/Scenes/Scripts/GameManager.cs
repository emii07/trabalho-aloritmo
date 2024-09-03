using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI hun, MsgVitoria;
    public int restantes;
    public AudioClip clipmoeda, clipvitoria;

    private AudioSource Source;
    
    void Start()
    {
        TryGetComponent(out Source);
        restantes = FindObjectsOfType<moeda>().Length;
        hun.text = $"moedas restantes: {restantes}";
    }

    public void Subtrairmoedas(int valor)
    {
        restantes = restantes - valor;
        hun.text = $"moedas restantes: {restantes}";
        Source.PlayOneShot(clipmoeda);
        if (restantes <= 0)
        {
            MsgVitoria.text = "PARABÉNS!!";
            Source.Stop();
            Source.PlayOneShot(clipvitoria);
        }
    }
    
    void Update()
    {
        
    }
}
