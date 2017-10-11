using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour {
    int number = 20;
    int min = 0;
    int max = 100;

    void Check()
    {
        if(number <= min)
        {
            print("the number reached the minimum");
            UnityEditor.EditorApplication.isPlaying = false;
        }
        if (number >= max)
        {
            print("the number reached the maximum");
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }

	// Use this for initialization
	void Start () {
        print(number);
        print("up = +1; down = -1; left = +10; right = -10");
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            number = number + 1;
            print(number);
            Check();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            number = number - 1;
            print(number);
            Check();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            number = number + 10;
            print(number);
            Check();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            number = number - 10;
            print(number);
            Check();
        }
    }
}
