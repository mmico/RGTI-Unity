using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float moveSpeed;
    public float turnSpeed;
    public float lookX;
    public float lookY;
    float rotation = 0.0f;
    private new Transform camera;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        camera = this.gameObject.transform.GetChild(7);
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            anim.SetBool("Forward", true);
        }
        else
        {
            anim.SetBool("Forward", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            anim.SetBool("Backward", true);
        }
        else
        {
            anim.SetBool("Backward", false);
        }

        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        lookX = Input.GetAxis("Mouse X") * turnSpeed/30;
        lookY = Input.GetAxis("Mouse Y") * turnSpeed / 30;

        transform.Rotate(Vector3.up, lookX);

        if (rotation + lookY > 90.0f)
            lookY = lookY - (rotation + lookY - 90.0f);

        if (rotation + lookY < -90.0f)
            lookY = lookY - (rotation + lookY + 90.0f);

        //if (rotation  <= 90.0f && rotation >= -90.0f )
        //{
            camera.transform.Rotate(Vector3.left, lookY);
            rotation += lookY;
        //}

       
    }
}
