using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public int velocidade = 10;
     private Rigidbody rb;
    void Start()
    {
        TryGetComponent(out rb);
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
        
}
}
