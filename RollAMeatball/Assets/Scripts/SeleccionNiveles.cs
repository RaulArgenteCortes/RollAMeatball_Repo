using UnityEngine;
using UnityEngine.SceneManagement;

public class SeleccionNiveles : MonoBehaviour
{
    // Funci�n para cargar el Nivel 1
    public void CargarNivel1()
    {
        SceneManager.LoadScene("Level1");
    }

    // Funci�n para cargar el Nivel 2
    public void CargarNivel2()
    {
        SceneManager.LoadScene("level2");
    }

    // Funci�n para cargar el Nivel 3
    public void CargarNivel3()
    {
        SceneManager.LoadScene("Level3");
    }

    // Funci�n para volver al men� principal
    public void VolverAlMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
