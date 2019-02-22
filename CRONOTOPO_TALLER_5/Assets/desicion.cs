﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desicion : MonoBehaviour {

    private Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("right"))
        {
            animator.SetTrigger("decide_patear");
        }

        else if(Input.GetKeyDown("up"))
        {
            animator.SetTrigger("decide_ignorar");
        }
	}
}
