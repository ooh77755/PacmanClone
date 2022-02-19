using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{

    CircleCollider2D myCollider;

    void Start()
    {
        myCollider = GetComponent<CircleCollider2D>();
    }

    void Update()
    {
        if(myCollider.IsTouchingLayers(LayerMask.GetMask("FG")))
        {
            Debug.Log("Is touching wall");
        }
    }
}
