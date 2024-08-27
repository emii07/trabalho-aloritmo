using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public int velocidade = 10;
    private Rigidbody rb;
    public int forcaPulo = 10;
    public bool noChao = false
            ;
    void Start()
    {
        TryGetComponent(out rb);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (Collision.gameObject.tag == "chão")
        {
            noChao = true;
        }
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
        if (Input.GetKeyDown(KeyCode.Space) && noChao) //PULO
        {
            rb.AddForce(Vector3.up * forcaPulo,ForceMode.Impulse);
        }
               
        
        
        
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
        
}
}
