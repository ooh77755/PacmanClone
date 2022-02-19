using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float withinRange = 5f;
    [SerializeField] float speed = 5f;

    void Update()
    {
        float dist = Vector2.Distance(target.position, transform.position);
        float step = speed * Time.deltaTime;

        if (dist <= withinRange)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, step);
        }

        else
        {
            return;
        }
    }
}
