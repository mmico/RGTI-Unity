using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat_Move1 : MonoBehaviour
{

    public GameObject[] waypoints;
    public int num = 0;

    public float speed;
    public float minDist;

    void Update()
    {

        float dist = Vector3.Distance(gameObject.transform.position, waypoints[num].transform.position);

        if (dist > minDist)
        {
            Move();
        }
        else
        {
            if (num + 1 == waypoints.Length)
            {
                num = 0;
            }
            else
            {
                num++;
            }
        }

    }

    public void Move()
    {
        transform.LookAt(waypoints[num].transform.position);
        transform.eulerAngles = new Vector3(0, transform.rotation.eulerAngles.y - 90, 0);
        transform.position += gameObject.transform.right * speed * Time.deltaTime;
    }

}


