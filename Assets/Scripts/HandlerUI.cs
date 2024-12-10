using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HandlerUI : MonoBehaviour
{
    [SerializeField]

    GameObject objetoPanel;

    int contador = 0;

    float cont_tiempo;
    [SerializeField] TextMeshProUGUI texto_contador;

    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
        cont_tiempo = 0;
        texto_contador.text = cont_tiempo.ToString();
        objetoPanel.SetActive(false);    
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex==0  && objetoPanel.activeSelf){   
            cont_tiempo += Time.deltaTime;
            if(cont_tiempo >= 1f)
            {
                contador++;
                texto_contador.text = contador.ToString();
                cont_tiempo = 0;
            }

        }
    }

    public void activaPanel(bool isVisible)
    {
        contador = 0;
        texto_contador.text = contador.ToString();
        objetoPanel.SetActive(isVisible);
    }

}
