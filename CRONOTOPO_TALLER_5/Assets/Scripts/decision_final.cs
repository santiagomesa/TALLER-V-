using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decision_final : MonoBehaviour {

    //private bool encendidoy;
    //private bool encendidon;
    private Animator animator;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        //encendidoy = false;
        //encendidon = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("y"))
        {
            animator.SetTrigger("tocar_luz");
            //encendidoy = true;

            /*if(Input.GetKeyDown("y") && encendidoy == true)
            {
                animator.ResetTrigger("tocar_luz");
                encendidoy = false;
            }*/
        }

        else if (Input.GetKeyDown("n"))
        {
            animator.SetTrigger("ver_luz");
            //encendidon = true;

            /*if (Input.GetKeyDown("n") && encendidon == true)
            {
                animator.ResetTrigger("ver_luz");
                encendidon = false;
            }*/

        }
    }
}
