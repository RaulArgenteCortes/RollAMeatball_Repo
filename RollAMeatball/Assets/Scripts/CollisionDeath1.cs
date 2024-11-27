using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDeath1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject finishCanvas;
    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle")) {
            //Debug.Log("Collision with an Obstacle");
            SceneManager.LoadScene(1);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object collided with has the "Finish" tag
        if (other.CompareTag("Finish"))
        {
            // Show the Canvas
            finishCanvas.SetActive(true);

            // Optionally, disable the player or pause the game
            // Time.timeScale = 0; // Uncomment to pause the game
        }
    }

}
