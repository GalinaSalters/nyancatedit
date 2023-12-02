using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public GameObject playerPrefab;
    public Vector3 position = new(0, 0, 0);
    public Quaternion rotation = Quaternion.identity;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("It works!");
        
        // check if prefab attached to script
        if (playerPrefab != null) 
        {
            Instantiate(playerPrefab, position, rotation);
        }
        else 
        {
            Debug.LogError("Player Prefab is not attached to Player Script. \nCan not instantiate null");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
