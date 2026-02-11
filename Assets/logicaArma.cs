using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicaArma : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Generales")]
    public AudioSource audiosource;
    public Animator animator;

    [Header("Sonidos")]
    public AudioClip SonInicio;
    public AudioClip SonDisparo;
    public AudioClip SonSinBalas;
    public AudioClip SonCargaIn;
    public AudioClip SonCargaOut;

    [Header("Val. Arma")]
    public int totalBalas = 100;
    public int balasEnCartucho = 12;

    [Header("Referencias")]
    public Transform puntoDisparo;
    public float dano=20f; 

    [Header("Enemigo")]
    public GameObject GOEnemigo;
    //public Vida vida;

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {


            if (balasEnCartucho > 0)
            {
                RaycastHit hit;
                if (Physics.Raycast(puntoDisparo.position, puntoDisparo.TransformDirection(Vector3.forward), out hit, 50))
                {
                    if(hit.collider.tag=="Enemigo")
                    {
                        GOEnemigo = hit.collider.gameObject;
			            Vida vida = GOEnemigo.GetComponent<Vida>();   
			            vida.RecibirDano(dano); 
                        Debug.Log("Le di..."+GOEnemigo.name);
                    }
                }
                animator.CrossFadeInFixedTime("Fire", 0.1F);
                audiosource.PlayOneShot(SonDisparo);
                balasEnCartucho -= 1;
            }
            else  
            {
                animator.CrossFadeInFixedTime("Fire", 0.1F);
                audiosource.PlayOneShot(SonSinBalas);
            }
        }

        if(Input.GetButtonDown("Reload"))
        {
            if(balasEnCartucho==0)
            {
                animator.CrossFadeInFixedTime("Reload", 0.1F);
                totalBalas -= 12;
                balasEnCartucho += 12;
            }
        }
    }

    void CargaArma()
    {
        audiosource.PlayOneShot(SonInicio);
    }

    void CargaIn()
    {
        audiosource.PlayOneShot(SonCargaIn);
    }
    void CargaOut()
    {
        audiosource.PlayOneShot(SonCargaOut);
    }
}
