using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    RaycastHit hit;
    private new Transform camera;
    private new GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        camera = this.gameObject.transform.GetChild(0);
        canvas = GameObject.Find("Canvas");
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GameState.canOpenDoor.Count);
        if (Physics.Raycast(camera.transform.position, camera.transform.TransformDirection(Vector3.forward), out hit, 2.0f))
        {
            if (hit.collider.gameObject.tag == "Key") {
                canvas.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    hit.collider.gameObject.GetComponent<Key>().Interact();
                    canvas.SetActive(false);
                }
            }

            if (hit.collider.gameObject.tag == "Door")
            {
                canvas.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    hit.collider.gameObject.GetComponent<Door>().Interact();
                    canvas.SetActive(false);
                }
            }

            if (hit.collider.gameObject.tag == "Switch")
            {
                canvas.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    hit.collider.gameObject.GetComponent<Switch>().Interact();
                    canvas.SetActive(false);
                }
            }
        }
        else
        {
            canvas.SetActive(false);
        }
    }
}
