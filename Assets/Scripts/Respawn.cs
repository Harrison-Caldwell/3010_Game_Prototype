using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject Player;
    public GameObject RespawnPoint01;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);

        //Debug.Log(Player.transform.position);
        //Debug.Log(RespawnPoint01.transform.position);
        other.transform.position = RespawnPoint01.transform.position;
        //Debug.Log(Player.transform.position);
        //Debug.Log(RespawnPoint01.transform.position);
    }


}
