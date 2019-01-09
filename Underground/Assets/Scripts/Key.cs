using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    public string color;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        this.tag = "Untagged";
        GameState.canOpenDoor[color] = true;
        this.gameObject.SetActive(false);
    }
}
