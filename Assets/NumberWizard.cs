using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        int min = 1;
        int max = 1000;


        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number in the following range.");
        Debug.Log("The lowest number is " + min);
        Debug.Log("The highest number is " + max);
        Debug.Log("Tell if your number is lower or higher than 500.");
        Debug.Log("Push Down = Lower, Push Up = Higher, Enter = Correct");
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            Debug.Log("Down Arrow was pressed.");
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            Debug.Log("Up Arrow was pressed.");
        }
        if(Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("Enter was pressed.");
        }
    }
}
