using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int min = 1;
    int max = 1000;
    int guess = 500;

    // Start is called before the first frame update
    void Start() {
        StartGame();
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            max = guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow)){
            min = guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("I win!");
            StartGame();
        }
    }

    void StartGame() {

        min = 1;
        max = 1000;
        guess = 500;

        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number in the following range.");
        Debug.Log("The lowest number is " + min);
        Debug.Log("The highest number is " + max);
        Debug.Log("Tell me if your number is lower or higher than " + guess);
        Debug.Log("Push Down = Lower, Push Up = Higher, Enter = Correct");
        max = max + 1;
    }

    void NextGuess() {
        guess = (max + min) / 2;
        Debug.Log("Tell me if your number is lower or higher than " + guess);
    }
}
