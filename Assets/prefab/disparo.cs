using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    [Header("Prefab y punto de disparo")]
    public GameObject balaPrefab;
    public Transform puntoDisparo;

    [Header("Parámetros de disparo")]
    public float fuerzaDisparo = 500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Disparar();
        }
    }

    void Disparar()
    {
        if (balaPrefab == null || puntoDisparo == null)
        {
            Debug.LogWarning("Falta asignar balaPrefab o puntoDisparo");
            return;
        }

        GameObject bala = Instantiate(
            balaPrefab,
            puntoDisparo.position,
            puntoDisparo.rotation
        );

        Rigidbody rb = bala.GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogWarning("La bala no tiene Rigidbody");
            return;
        }

        rb.AddForce(puntoDisparo.forward * fuerzaDisparo, ForceMode.Impulse);

        // Opcional: destruir la bala tras X segundos
        Destroy(bala, 5f);
    }
}
