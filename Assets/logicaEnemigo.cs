using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicaEnemigo : MonoBehaviour
{
    public Transform Jugador;
    public Transform pivoteRotacion;
    // Start is called before the first frame update
    void Start()
    {
            Jugador = GameObject.FindGameObjectWithTag("Player").transform;
            if(pivoteRotacion == null) pivoteRotacion = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
        Debug.Log("Player detectado");
        transform.parent.LookAt(Jugador);
    }
    }

    void OnTriggerStay(Collider other) {
        if(other.CompareTag("Player")) {
        Debug.Log("Player detectado");
        transform.parent.LookAt(Jugador);
    }
    }
}
