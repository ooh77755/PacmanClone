using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Transform player;
    float moveSpeed = 4f;
    float MaxDist = 10f;
    float MinDist = 5f;

    void Start()
    {

    }
    
    void Update()
    {
        //transform.LookAt(player);
        if(Vector3.Distance(transform.position,player.position) >= MinDist)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }

        if(Vector3.Distance(transform.position,player.position) <= MaxDist)
        {
            Debug.Log("Test");
        }
    }
}
