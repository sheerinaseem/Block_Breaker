using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{

    public int max;
    public int min;
    public Text myGuess;
    int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
        max = max + 1; 
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }


    void NextGuess()
    {
        guess = Random.Range(min,max);
        myGuess.text = guess.ToString();
    }
}
