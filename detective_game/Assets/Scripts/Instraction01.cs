using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Instraction01 : MonoBehaviour
{
    [SerializeField] InputField inputField;
    public void CheckAnswer()
    {
        int rightAnswer = 4806;
        int userInput;
        if (int.TryParse(inputField.text, out userInput))
        {
            if (userInput == rightAnswer)
            {
                Debug.Log("ОК");
            }
            else
            {
                Debug.Log("Числа не совпадают");
            }
        }
        else
        {
            Debug.Log("Введите корректное число");
        }
    }
}

