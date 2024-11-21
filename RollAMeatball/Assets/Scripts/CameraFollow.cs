using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform followTarget1; //Referencia al objeto que tiene que seguir la cámara
    public Transform followTarget2;
    public Vector3 offset; //Variable para almacenar la diferencia vectorial entre cámara y objetivo.

    void Start()
    {
        //El vector comparativo entre dos posiciones surge de:
        //Vector del objetivo - vector original (en este caso, la cámara)
        offset = followTarget1.position - transform.position;
    }

    void LateUpdate()
    {
        //Los movimientos de cámara se suelen codear en el LastUpdate()
        Follower();
    }

    void Follower()
    {
        transform.position = followTarget1.position - offset; //La posición de la cámara = posicion del objeto
    }
}

