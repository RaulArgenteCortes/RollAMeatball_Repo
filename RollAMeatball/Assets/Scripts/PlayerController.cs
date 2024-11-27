using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Public References")]
    public Rigidbody playerRB; //Variable para referenciar el rigidBody del Jugador y as� poder modificarlo cuando quiera mediante c�digo
    [Header("Movement Variables")] //Header es un metodo de agrupar "x" variables u otros
    public float speed;
    private float horInput; //Variable del vector X del input 
    private float verInput; //Variable del vector Y del input (se lo pasar� al eje Z)
    [Header("Jump Variables")]
    public float jumpForce;
    public bool isGrounded = true;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Conectar las variables float al input de Teclado
        horInput = Input.GetAxis("Horizontal");
        verInput = Input.GetAxis("Vertical");
        Jump();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) {
            isGrounded = true;
        };
    }



    void Movement() {   //Velocidad de rigidbody = Vector3 (movimiento en X, constante Y, movimiento en Z)
        playerRB.velocity = new Vector3(horInput*speed,playerRB.velocity.y,verInput*speed);
    }

    void Jump() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (isGrounded == true) {
                isGrounded = false;
                playerRB.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
            }
        }
    }
    //Fixed Update -> Para f�sicas
    //Update -> Para lo relaci�nado con Botones(Key Inputs)

}
