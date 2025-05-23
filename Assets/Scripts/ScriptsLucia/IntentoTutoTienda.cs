using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class IntentoTutoTienda : MonoBehaviour
{
    public Canvas TiendaTutorialCanvas;
    public Canvas gameOverCanvas;
    public GameObject PantallaTienda;
    public GameObject cannon;
    public float DineroActual;
    public TextMeshProUGUI botonBuy1Text;
    public TextMeshProUGUI botonBuy2Text;
    public TextMeshProUGUI botonBuy3Text;
    public TextMeshProUGUI botonBuy4Text;

    public TextMeshProUGUI textoMonedas;

    public GameObject imagen1;

    bool comprado = false;

    // Start is called before the first frame update
    void Start()
    {
        DineroActual = 250f;
        Time.timeScale = 0;
        cannon.SetActive(false);
        HideAllCanvasesExceptTienda();
        ActualizarTextoMonedas();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ActualizarTextoMonedas()
    {
        textoMonedas.text = "Monedas: " + DineroActual.ToString("F0");

    }
    public void Buy1()
    {
        if (DineroActual >= 250f)
        {
            DineroActual -= 250f;
            botonBuy1Text.text = "Comprado";
            comprado = true;
            imagen1.SetActive(false);
            ActualizarTextoMonedas();
        }
        else
        {
            botonBuy1Text.text = "Insuficiente";
        }
    }
    public void Buy2()
    {
        botonBuy2Text.text = "No disponible";
    }
    public void Buy3()
    {
       botonBuy3Text.text = "No disponible";
    }
    public void Buy4()
    {
        botonBuy4Text.text = "No disponible";
    }
    public void continuar()
    {
        if(comprado == true)
        {
            Time.timeScale = 1;
            ShowAllCanvasesExceptTienda();
        }
        else
        {
            Debug.Log("No has comprado");
        }
        
    }

    void HideAllCanvasesExceptTienda()
    {
        Canvas[] canvases = FindObjectsOfType<Canvas>();

        foreach (Canvas canvas in canvases)
        {
            if (canvas != TiendaTutorialCanvas)
                canvas.enabled = false;
        }

        if (TiendaTutorialCanvas != null)
        {
            TiendaTutorialCanvas.enabled = true;
        }

    }
    void ShowAllCanvasesExceptTienda()
    {
        Canvas[] canvases = FindObjectsOfType<Canvas>();

        foreach (Canvas canvas in canvases)
        {
            if (canvas != TiendaTutorialCanvas)
                canvas.enabled = true;
        }

        if (TiendaTutorialCanvas != null && gameOverCanvas != null)
        {
            TiendaTutorialCanvas.enabled = false;
            gameOverCanvas.enabled = false;
        }
        cannon.SetActive(true);
    }
}
