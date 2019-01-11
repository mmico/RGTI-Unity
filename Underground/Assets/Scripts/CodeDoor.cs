using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeDoor : MonoBehaviour
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
        if (GameState.correctCode)
        {
            animator.SetBool("DoorOpen", true);
            //clip.Play();
        }
    }
}
