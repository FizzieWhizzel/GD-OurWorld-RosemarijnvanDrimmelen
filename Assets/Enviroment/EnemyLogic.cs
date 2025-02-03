using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    public GameObject respawnLocation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision col)
    {

        if (col.gameObject.CompareTag("Player"))
        {
            //PlayerDeath(col);
            col.gameObject.transform.position = respawnLocation.transform.position + (Vector3.up*2);
        }
    }

    
}
