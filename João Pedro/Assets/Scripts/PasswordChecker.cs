using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PasswordChecker : MonoBehaviour
{
    public string password;
    public TextMeshProUGUI debugText;
    public string nextSceneName;

    public void OnValueChanged(string text)
    {
        if(text == password)
        {
            debugText.text = "Senha Correta";
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            debugText.text = "Senha Incorreta";
        }
    }
}
