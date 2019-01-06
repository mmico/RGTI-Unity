using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GameState.canOpenDoor.Count);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 1.5f))
        {
            if (hit.collider.gameObject.tag == "Key") {
                if (Input.GetKey(KeyCode.E))
                {
                    hit.collider.gameObject.GetComponent<Key>().Interact();
                }
            }

            if (hit.collider.gameObject.tag == "Door")
            {
                if (Input.GetKey(KeyCode.E))
                {
                    hit.collider.gameObject.GetComponent<Door>().Interact();
                }
            }
        }
    }
}
