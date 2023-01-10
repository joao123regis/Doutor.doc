using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class upright : MonoBehaviour
{
    string Code = "MEMBRANA"; 
    string Letra = null; 
    int LetraIndex = 0; 
    string Alpha; 
    public Text UiText = null; 
    [SerializeField] private Animator Door; 

    public void CodeFunction(string Letras)
    {
        LetraIndex++; 
        Letra = Letra + Letras; 
        UiText.text = Letra;  

    }
    public void Enter()
    {
        if (Letra == Code)
        {
            UiText.text = "Correto"; 
            Door.SetBool("Open", true);
            StartCoroutine("StopDoor"); 
        }
        else
        {
            UiText.text = "Incorreto!"; 

        }
    }
    public void Delete()
    {
        LetraIndex++; 
        Letra = null; 
        UiText.text = Letra;
    }
    IEnumerator StopDoor()
    {
        yield return new WaitForSeconds(1f); 
        Door.SetBool("Open", false);
        Door.enabled = false; 
    }
}

