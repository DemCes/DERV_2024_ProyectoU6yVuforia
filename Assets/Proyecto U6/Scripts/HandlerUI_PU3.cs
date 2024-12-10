using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HandlerUI_PU3 : MonoBehaviour
{
    [SerializeField]
    GameObject objetoPanel;


    // Start is called before the first frame update
    void Start()
    {
        objetoPanel.SetActive(false);
    }

    // Método para activar o desactivar el panel
    public void activaPanel(bool isVisible)
    {
        objetoPanel.SetActive(isVisible);
    }
}