using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Manager : MonoBehaviour
{

    [SerializeField] private string NomeLevel;
    [SerializeField] GameObject MenuInicial;
    [SerializeField] GameObject opcoes;


    public void Jogar()
    {
        SceneManager.LoadScene(NomeLevel);

    }
    public void AbrirOpcoes()
    {
        MenuInicial.SetActive(false);
        opcoes.SetActive(true);
    }

    public void FecharOpcoes()
    {
        opcoes.SetActive(false);
        MenuInicial.SetActive(true);
    }

    public void SairJogo()
    {
        Debug.Log("Sair Do Jogo");
        Application.Quit();
    }
     public void Menu()
    {
        opcoes.SetActive(false);
        MenuInicial.SetActive(true);
    }
}
