﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGate : MonoBehaviour
{

    Animator anim;
    AudioSource clip;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
        clip = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameState.switchOn)
        {
            anim.SetBool("OpenGate", true);
            clip.Play();
        }
    }
}
