using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicaArma : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audiosource;
    public Animator animator;
    public AudioClip SonInicio;
    public AudioClip SonDisparo;


    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();

        audiosource.PlayOneShot(SonInicio);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            animator.CrossFadeInFixedTime("Fire", 0.1F);
            audiosource.PlayOneShot(SonDisparo);
        }
    }
}
