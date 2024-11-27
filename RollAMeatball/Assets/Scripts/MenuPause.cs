using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject panelPausa; // Referencia al menú de pausa
    private bool estaPausado = false;

    void Update()
    {
        // Detectar la tecla Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (estaPausado)
            {
                ReanudarJuego();
            }
            else
            {
                PausarJuego();
            }
        }
    }

    public void PausarJuego()
    {
        panelPausa.SetActive(true); // Muestra el menú de pausa
        Time.timeScale = 0f;       // Detiene el tiempo del juego
        estaPausado = true;        
    }

    public void ReanudarJuego()
    {
        panelPausa.SetActive(false); // Oculta el menú de pausa
        Time.timeScale = 1f;        
        estaPausado = false;        
    }


    public void SalirAlMenuPrincipal()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("MainMenu"); // Dirige al menu
    }
}
