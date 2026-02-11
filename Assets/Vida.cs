using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public float valor = 100;
    // Start is called before the first frame update
    
    public void RecibirDano(float dano)
	{
		valor -=dano;
		if (valor <=0)
		{
			valor=0;
			Destroy(this.gameObject, 0.1f);
		}
	}
	
}
