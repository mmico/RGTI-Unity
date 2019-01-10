using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    RaycastHit hit;
    private new Transform camera;
    private new GameObject canvas;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        camera = this.gameObject.transform.GetChild(7);
        canvas = GameObject.Find("Canvas");
        canvas.SetActive(false);
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(camera.transform.position, camera.transform.TransformDirection(Vector3.forward), out hit, 2.0f))
        {
            if (hit.collider.gameObject.tag == "Key") {
                canvas.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    hit.collider.gameObject.GetComponent<Key>().Interact();
                    canvas.SetActive(false);
                    pickUpAnim();
                }
            }

            if (hit.collider.gameObject.tag == "Door")
            {
                canvas.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    hit.collider.gameObject.GetComponent<Door>().Interact();
                    canvas.SetActive(false);
                    pickUpAnim();
                }
            }

            if (hit.collider.gameObject.tag == "Switch")
            {
                canvas.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    hit.collider.gameObject.GetComponent<Switch>().Interact();
                    canvas.SetActive(false);
                    pickUpAnim();
                }
            }
        }
        else
        {
            canvas.SetActive(false);
        }
    }

    void pickUpAnim()
    {
        anim.SetBool("PickUp", true);
        //anim.SetBool("PickUp", false);
    }
}
