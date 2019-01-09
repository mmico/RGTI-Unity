using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat_Move : MonoBehaviour
{
    public float moveSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
}
