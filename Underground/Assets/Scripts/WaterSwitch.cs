using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSwitch : MonoBehaviour
{
    Animator animator;
    AudioSource clip;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        clip = this.GetComponent<AudioSource>();
        GameState.waterDown = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Interact()
    {
        this.tag = "Untagged";
        if (!GameState.waterDown)
        {
            GameState.waterDown = true;
            animator.SetBool("MoveSwitch", true);
            clip.Play();
        }
    }
}
