using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    //Created global int variables 
    int max = 1000;
    int min = 1;
    int guess = 500;
    
    void StartGame(){
        //Prints these only once
        print("Welcome to NumeberWizard");
        Debug.Log("Think a number from " + min + " to " + max);
        NextGuess();
    }
    void NextGuess() {
        Debug.Log("Is the number greater than " + guess + "?");
        Debug.Log("Up : Bigger, Down: Smaller, Return: Equel");
    }

    // Use this for initialization
    void Start () {
        StartGame();
    }
    
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up Arrow pressed");
            min = guess;
            guess = (min + max) / 2;
            NextGuess();
        }

        //Checks if Down Arrow is pressed
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down Arrow pressed");
            max = guess;
            guess = (min + max) / 2;
            NextGuess();
        }

        //Checks if Return is pressed
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("You won!!!!");
            print("Press P to play again");
            print("Press Q to quit");

            if (Input.GetKeyDown(KeyCode.P))
            {
                StartGame();
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                UnityEditor.EditorApplication.isPlaying = false;
            }
        }
    }
}
