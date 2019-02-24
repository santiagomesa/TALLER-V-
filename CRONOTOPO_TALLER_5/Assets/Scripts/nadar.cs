using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nadar : MonoBehaviour {

    private Animator animator;
    private float tiempo;
    private int contador;

	// Use this for initialization
	void Start () {
        contador = 0;
        animator = GetComponent<Animator>();
        tiempo = Time.deltaTime; ;
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("right"))
        {
            tiempo = 0;
            contador += 1;
            if (contador >= 20)
            {
                animator.SetTrigger("logra_salir");
            }
            else if (contador < 20 && tiempo >= 20)
            {
                animator.SetTrigger("se_muere_alv");
            }
        }
    }
}
