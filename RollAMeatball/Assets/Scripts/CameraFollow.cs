using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [Header("Enfoques")]
    public Transform followTarget1;
    public Transform followTarget2;

    [Header("Separación")]
    public Vector3 offset; //Variable para almacenar la diferencia vectorial entre cámara y objetivo.

    void Start()
    {
        transform.position = offset + (followTarget1.position + followTarget2.position) / 2;
        //El vector comparativo entre dos posiciones surge de:
        //Vector del objetivo - vector original (en este caso, la cámara)
        offset = (followTarget1.position + followTarget2.position) / 2 - transform.position;
    }

    void LateUpdate()
    {
        //Los movimientos de cámara se suelen codear en el LastUpdate()
        Follower();
    }

    void Follower()
    {
        transform.position = (followTarget1.position + followTarget2.position) / 2 - offset; //La posición de la cámara = posicion del objeto
    }
}

