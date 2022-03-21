using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obsPrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private PlayerController playerCtrtl;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObs", 2, 2);
        playerCtrtl = GameObject.Find("Player").GetComponent<PlayerController>();

    }



    void SpawnObs()
    {
        if (playerCtrtl.gameOver == false)
        {
            Instantiate(obsPrefab, spawnPos, obsPrefab.transform.rotation);
        }

    }

}

    

    
    




