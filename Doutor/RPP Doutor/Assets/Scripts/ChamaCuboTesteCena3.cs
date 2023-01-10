using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChamaCuboTesteCena3 : MonoBehaviour
{
    bool moudeDentroDoObjeto;
    public string nomeDaCena = "cena";

    // Start is called before the first frame update
    void Start()
    {
        moudeDentroDoObjeto = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (moudeDentroDoObjeto == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(nomeDaCena);
            }
        }
    }
    //verificar se mouse está dentro do objeto;
    private void OnMouseEnter()
    {
        moudeDentroDoObjeto = true; 
    }
    private void OnMouseExit()
    {
        moudeDentroDoObjeto = false;
    }
}
