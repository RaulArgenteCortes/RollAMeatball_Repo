using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [Header("Enfoques")]
    public Transform followTarget1;
    public Transform followTarget2;

    [Header("Separaci�n")]
    public Vector3 offset; //Variable para almacenar la diferencia vectorial entre c�mara y objetivo.

    void Start()
    {
        transform.position = offset + (followTarget1.position + followTarget2.position) / 2;
        //El vector comparativo entre dos posiciones surge de:
        //Vector del objetivo - vector original (en este caso, la c�mara)
        offset = (followTarget1.position + followTarget2.position) / 2 - transform.position;
    }

    void LateUpdate()
    {
        //Los movimientos de c�mara se suelen codear en el LastUpdate()
        Follower();
    }

    void Follower()
    {
        transform.position = (followTarget1.position + followTarget2.position) / 2 - offset; //La posici�n de la c�mara = posicion del objeto
    }
}

