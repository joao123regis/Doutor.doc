using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChamaCenaCubo : MonoBehaviour
{
    bool mouseDentroDoObjeto;
    public string nomeDaCena = "cena";

    // Start is called before the first frame update
    void Start()
    {
        mouseDentroDoObjeto = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(mouseDentroDoObjeto == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(nomeDaCena);
            }
        }
    }
    void OnMouseEnter()
    {
        mouseDentroDoObjeto = true;
    }
    void OnMouseExit()
    {
        mouseDentroDoObjeto = false;
    }
}
