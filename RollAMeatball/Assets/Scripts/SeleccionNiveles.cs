using UnityEngine;
using UnityEngine.SceneManagement;

public class SeleccionNiveles : MonoBehaviour
{
    // Función para cargar el Nivel 1
    public void CargarNivel1()
    {
        SceneManager.LoadScene("Level1");
    }

    // Función para cargar el Nivel 2
    public void CargarNivel2()
    {
        SceneManager.LoadScene("level2");
    }

    // Función para cargar el Nivel 3
    public void CargarNivel3()
    {
        SceneManager.LoadScene("Level3");
    }

    // Función para volver al menú principal
    public void VolverAlMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
