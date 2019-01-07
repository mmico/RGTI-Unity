using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    Animator animator;
    AudioSource clip;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        clip = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        if (!GameState.switchOn)
        {
            GameState.switchOn = true;
            animator.SetBool("MoveSwitch", true);
            clip.Play();
        }
    }
}
