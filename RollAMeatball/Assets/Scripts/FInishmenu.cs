using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoriaSceneManager : MonoBehaviour
{
    
    public void VolverAlMenu()
    {
        SceneManager.LoadScene("MainMenu"); 
    }

    // Funci�n para salir del juego
    public void SalirDelJuego()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit(); 
    }
}
