using UnityEngine;
using UnityEngine.SceneManagement;  

public class PanelVictoria : MonoBehaviour
{
    public GameObject panelVictoria;  
    private string Level3;    

    void Start()
    {
        panelVictoria.SetActive(false); 
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  
        {
            MostrarPantallaVictoria();
        }
    }

    // Función que muestra la pantalla de victoria
    public void MostrarPantallaVictoria()
    {
        panelVictoria.SetActive(true);   // Activa el panel de victoria
        Time.timeScale = 0f;            
    }

    // Función para volver al menú principal
    public void VolverAlMenu()
    {
        Time.timeScale = 1f;  
        SceneManager.LoadScene("MainMenu");  
    }

    public void SiguienteNivel()
    {
        Time.timeScale = 1f;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
        //SceneManager.LoadScene("Level3");
    }


}
