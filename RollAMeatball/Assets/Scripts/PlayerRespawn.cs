using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{

    [Header("Respawn Parameters")]
    public Transform respawnPoint;
    public float respawnFallLimit;
    PlayerInteraction startRespawn1;
    PlayerInteraction startRespawn2;

    private void Start()
    {
        startRespawn1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<PlayerInteraction>();
        startRespawn2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<PlayerInteraction>();

        Respawn();
    }

    void Update()
    {
        if (transform.position.y <= respawnFallLimit)
        {
            CallRespawn();
            Respawn();
        }
    }

    void CallRespawn()
    {
        startRespawn1.Respawn();
        startRespawn2.Respawn();
    }

    void Respawn()
    {
        transform.position = respawnPoint.position;
    }

}
