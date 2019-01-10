using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    private new GameObject canvas;
    private string code = "";
    private new Text display;
    AudioSource[] clips;

    // Start is called before the first frame update
    void Start()
    {
        display = GameObject.Find("Code").GetComponent<Text>();
        canvas = GameObject.Find("CanvasKeypad");
        canvas.SetActive(false);
        clips = this.GetComponents<AudioSource>();
        GameState.inKeypad = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Interact()
    {
        canvas.SetActive(true);
        GameState.inKeypad = true;
    }

    public void exitKeypad()
    {
        code = "";
        display.text = "";
        canvas.SetActive(false);
        GameState.inKeypad = false;
    }

    public void buttonPresed(string s)
    {
        if (code.Length < 4)
        { 
            code += s;
            display.text = code;
        }
    }

    public void delete()
    {
        if (code.Length != 0)
        {
            code = code.Substring(0, code.Length - 1);
            display.text = code;
        }
    }

    public void check()
    {
        if (code.Equals("1520"))
        {
            GameState.correctCode = true;
            this.tag = "Untagged";
            canvas.SetActive(false);
            GameState.inKeypad = false;
            clips[0].Play();
        }
        else
        {
            code = "";
            display.text = "";
            clips[1].Play();
        }
    }
}
