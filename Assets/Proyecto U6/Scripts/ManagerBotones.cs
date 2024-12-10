using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerBotones : MonoBehaviour
{
    [SerializeField] private GameObject usoPanel;
    [SerializeField] private GameObject dosisPanel;
    [SerializeField] private GameObject precaucionesPanel;
    [SerializeField] private GameObject contraindicacionesPanel;

    private void Start()
    {
        HideAllPanels();
    }

    public void Iniciar(int panelIndex)
    {
        HideAllPanels();

        switch (panelIndex)
        {
            case 1: // Uso Principal
                usoPanel.SetActive(true);
                break;
            case 2: // Dosificación
                dosisPanel.SetActive(true);
                break;
            case 3: // Precauciones
                precaucionesPanel.SetActive(true);
                break;
            case 4: // Contraindicaciones
                contraindicacionesPanel.SetActive(true);
                break;
            case 5: // Botón retorno Uso
            case 6: // Botón retorno Dosis
            case 7: // Botón retorno Precauciones
            case 8: // Botón retorno Contraindicaciones
                HideAllPanels();
                break;
        }
    }

    private void HideAllPanels()
    {
        usoPanel.SetActive(false);
        dosisPanel.SetActive(false);
        precaucionesPanel.SetActive(false);
        contraindicacionesPanel.SetActive(false);
    }
}