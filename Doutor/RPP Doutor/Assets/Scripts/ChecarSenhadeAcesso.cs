using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChecarSenhadeAcesso : MonoBehaviour
{
    private InputField inputTextField;

    // Start is called before the first frame update
    void Start()
    {
        inputTextField = GetComponent<InputField>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChecarPalavraPasse()
    {
        switch (inputTextField.text)
        {
            case "membrana":
                SceneManager.LoadScene("CuboTesteCena3");
                break;

            default:
                inputTextField.text = "";
                break;
        }
    }
}
