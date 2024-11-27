using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform Respawn;
    public Transform PosPlayer;
    

    public void Dead () { PosPlayer.position=Respawn.position}
}
