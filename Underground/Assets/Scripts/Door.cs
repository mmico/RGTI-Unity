using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public string color;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
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
                animator.SetBool("DoorOpen", true);
            }
        }
    }
}
