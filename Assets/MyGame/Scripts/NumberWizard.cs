using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    public TextMeshProUGUI textField;
    public GameObject higher, lower, correct, newGame;
    int min = 1;
    int max = 200;
    int guess;



    // Start is called before the first frame update
    void Start()
    {
        RestartGame();
    }



    public void GuessIsLower()
    {
        max = guess - 1;
        NextGuess();
    }

    public void GuessIsHigher()
    {
        min = guess + 1;
        NextGuess();
    }
    
    public void GuessIsCorrect()
    {
        higher.SetActive(false);
        lower.SetActive(false);
        correct.SetActive(false);
        newGame.SetActive(true);
    }

    public void RestartGame()
    {
        higher.SetActive(true);
        lower.SetActive(true);
        correct.SetActive(true);
        newGame.SetActive(false);

        min = 1;
        max = 200;

        NextGuess();
    }

    private void NextGuess()
    {
        guess = (min + max) / 2;
        textField.text = guess.ToString();

    }
}
