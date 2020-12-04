using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NumberWizard : MonoBehaviour {
    int max;
    int min;
    int guess;
    public int maxGuessesAlowed = 10;
    public Text GuessText;
	void Start () {
        StartGame();
    }
    // Update is called once per frame
    void Update(){}

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }
    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }
    void StartGame()
    {
        max = 1001;
        min = 1;
        guess = Random.Range(min, max);
        GuessText.text = "Your Number is: " + guess.ToString();
    }
    void NextGuess()
    {
        maxGuessesAlowed--;
        if (maxGuessesAlowed <= 0)
        {
            SceneManager.LoadScene("Win");
        }
        else
        {
            guess = Random.Range(min,max);
            GuessText.text = "Your Number is: "+guess.ToString();
            if (max == min)
            {
                GuessText.text = "You can't trick me! Your number is: " + guess.ToString();
                StartGame();
            }
        }
    }
}
