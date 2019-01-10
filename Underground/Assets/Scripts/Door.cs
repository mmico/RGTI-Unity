using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public string color;
    Animator animator;
    AudioSource[] clips;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        clips = this.GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        if (GameState.canOpenDoor.ContainsKey(color))
        {
            if (GameState.canOpenDoor[color])
            {
                this.tag = "Untagged";
                animator.SetBool("DoorOpen", true);
                clips[1].Play();
            }
        }
        else
        {
            clips[0].Play();
        }
    }
}
