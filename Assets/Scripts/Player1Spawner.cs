using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Spawner : MonoBehaviour
{ 
    [SerializeField] private GameObject player1Prefab = null;

    // Start is called before the first frame update
    void Start()
    {
    PhotonNetwork.Instantiate(player1Prefab.name, Vector3.zero, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
