using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{

    [Header("Respawn Parameters")]
    public Transform respawnPoint;
    public float respawnFallLimit;
    PlayerRespawn startRespawn1;
    PlayerRespawn startRespawn2;

    private void Start()
    {
        startRespawn1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<PlayerRespawn>();
        startRespawn2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<PlayerRespawn>();

        Respawn();
    }

    void Update()
    {
        if (transform.position.y <= respawnFallLimit) {
            CallRespawn();
            Respawn();
        }
    }

    void CallRespawn ()
    {
        startRespawn1.Respawn();
        startRespawn2.Respawn();
    }

    void Respawn()
    {
        transform.position = respawnPoint.position;
    }

}
