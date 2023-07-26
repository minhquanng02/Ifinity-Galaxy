using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject playerPrefab;

    float range = 40;

    private void Start()
    {
        Vector2 randomPosition = new Vector2(Random.Range(-range, range), Random.Range(-range, range));
        PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
    }
}
