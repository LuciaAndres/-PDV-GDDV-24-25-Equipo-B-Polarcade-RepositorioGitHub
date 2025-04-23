using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NivelSuperado : MonoBehaviour
{
    // Start is called before the first frame update
    public void SiguienteNivel() {
        ControladorNivel.instancia.AumentarNiveles();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void MenuInicial()
    {
        ControladorNivel.instancia.AumentarNiveles();
        SceneManager.LoadScene("SampleScene");
    }
}
