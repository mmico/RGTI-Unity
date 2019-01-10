using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameState
{
    public static Dictionary<string, bool> canOpenDoor = new Dictionary<string, bool>();

    public static bool switchOn = false;

    public static bool inKeypad = false;

    public static bool correctCode = false;

    public static bool gamePaused = false;

    // Start is called before the first frame update
   /* void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
