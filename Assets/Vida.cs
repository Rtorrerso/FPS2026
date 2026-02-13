using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
	public Animator Eanimator;
    public float valor = 100;
    // Start is called before the first frame update
    void Start()
	{
		Eanimator = GetComponent<Animator>();
	}
    public void RecibirDano(float dano)
	{
		valor -=dano;
		if (valor <=0)
		{
			valor=0;
			Eanimator.CrossFadeInFixedTime("Z_FallingBack", 0.1f);
			Destroy(this.gameObject, 2f);
		}
	}
	
}
