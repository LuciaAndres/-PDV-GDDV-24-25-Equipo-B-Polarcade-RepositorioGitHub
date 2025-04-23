using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElegirBotonAccionBotones : MonoBehaviour
{
    public GameObject dificultad;
    public GameObject canvasBotones;
    public void Tutorial()
    {
        canvasBotones.SetActive(false);
        dificultad.SetActive(true);
    }
    public void Atras()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
