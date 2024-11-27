using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    //This is the movement controller script for the Level 2, the level should last more than 30 seconds and less than 2 minutes and 30 seconds
    // Start is called before the first frame update
    //This wouldn't be possible without the videos from DIGICANMEDIA(his channel: https://www.youtube.com/@CSHCPhotographyJRogowy) and various web posts and blogs. Also the work from the entire team.
    public float playerFallSpeed = 1.5f;
    public float playerMovement = 2.50f;
    
    // Update is called once per frame
    void Update()
    {
        //A is for Onwards (The reason is the camera orientation)
                    transform.Translate(Vector3.right * Time.deltaTime * playerMovement );
        
        //D is for Backwards (Same reason as before)
        //transform.Translate(Vector3.left * playerFallSpeed);

        //Move to the side
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector3.forward * Time.deltaTime * playerMovement );
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.back * Time.deltaTime * playerMovement);
        }
       
    }
}
