﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test8 : MonoBehaviour
{
    private Animation anim;

    private Animation clip;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            anim.animatePhysics = false;
         
        }
    }
}
