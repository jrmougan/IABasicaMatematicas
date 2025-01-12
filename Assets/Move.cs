﻿using UnityEngine;

public class Move : MonoBehaviour
{

    public GameObject goal;
    Vector3 direction;
    float speed = 5.0f;


    void Start()
    {

    }

    private void LateUpdate()
    {
        direction = goal.transform.position - transform.position;
        this.transform.LookAt(goal.transform.position);
        if (direction.magnitude > 2)
        {
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            this.transform.position += velocity;
        }

    }
}
