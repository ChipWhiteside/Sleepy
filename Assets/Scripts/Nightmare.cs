using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nightmare : MonoBehaviour
{

    public Transform sleepy;
    public float speed;

    void Start()
    {

    }

    void Update()
    {
        if (Vector2.Distance(transform.position, sleepy.transform.position) > 7.5)
            transform.position = Vector3.MoveTowards(transform.position, sleepy.position, (speed * 2.5f) * Time.deltaTime);
        else
            transform.position = Vector3.MoveTowards(transform.position, sleepy.position, speed * Time.deltaTime);
    }

    void SpeedIncrease()
    {
        speed += .1f;
    }
}
