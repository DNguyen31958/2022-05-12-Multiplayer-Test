using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerSpawnScript : MonoBehaviour
{
    public GameObject playerPrefab;

    void Start()
    {
        Vector2 randomPos = new Vector2(Random.Range(-8,9), 0);
        PhotonNetwork.Instantiate(playerPrefab.name, randomPos, Quaternion.identity);
    }
}
