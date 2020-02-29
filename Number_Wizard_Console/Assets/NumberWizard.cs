using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;

    void Start () {
        StartGame();
	}

    void StartGame()
    {
        max = 1000;
        min = 0;
        guess = 500;

        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number and don't tell me what it is..");
        Debug.Log("The Highest number you can pick is " + max);
        Debug.Log("The lowest number you can pick is " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Press up key, if it's higher");
        Debug.Log("Press down key, if it's lower");
        Debug.Log("Press Enter if it's a correct guess");
        max = max + 1;
    }

    void Update () 
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Match found");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than " + guess);
    }
}
