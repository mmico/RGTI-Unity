using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{

    public MovieTexture movie;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        GetComponent<RawImage>().texture = movie as MovieTexture;
        movie.loop = true;
        movie.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
