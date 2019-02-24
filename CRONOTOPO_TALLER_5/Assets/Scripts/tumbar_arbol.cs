using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tumbar_arbol : MonoBehaviour {

    private Animator animator;
    private int contador;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("right"))
        {
            contador += 1;
            if (contador >= 10)
            {
                animator.SetTrigger("tumbar_arbol");
            }
        }
    }
}
	
