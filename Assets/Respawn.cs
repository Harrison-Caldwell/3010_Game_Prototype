using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject Player;
    public GameObject respawnPoint01;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("player hit box");
        Debug.Log(Player.transform.position);
        Debug.Log(respawnPoint01.transform.position);
        Player.transform.position = respawnPoint01.transform.position;
        Debug.Log(Player.transform.position);
        Debug.Log(respawnPoint01.transform.position);
    }


}
