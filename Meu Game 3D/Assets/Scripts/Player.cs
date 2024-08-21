using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");
        TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update");
        float h = Input.GetAxis("Horizontal"); // -1 esquerda,0 nada, 1 direita
        float v = Input.GetAxis("vertical"); // -1 pra tras,0 nada,1 pra frente
    }
}
