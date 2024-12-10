using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HandlerUI2 : MonoBehaviour
{
    [SerializeField]
    GameObject objetoPanel;

    [SerializeField] TextMeshProUGUI texto;

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