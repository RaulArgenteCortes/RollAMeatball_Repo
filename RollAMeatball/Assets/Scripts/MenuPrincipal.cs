using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject panelInstrucciones; // Referencia al Panel de Instrucciones

    public void LevelSelector()
    {
        // el selector de niveles
        SceneManager.LoadScene("LevelSelector");
    }

    public void MostrarInstrucciones()
    {
        // Muestra u oculta el Panel de Instrucciones
        bool isActive = panelInstrucciones.activeSelf;
        panelInstrucciones.SetActive(!isActive); // Alterna el estado del panel
    }

    public void SalirDelJuego()
    {
        // Sale del juego 
        Debug.Log("ExitGame");
        Application.Quit();
    }
    public void CerrarInstrucciones()
    {
        panelInstrucciones.SetActive(false); // Oculta el panel
    }

}
