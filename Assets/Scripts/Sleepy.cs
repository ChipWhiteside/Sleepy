using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleepy : MonoBehaviour
{
    public static Sleepy instance;

    public int fear;        // How many nightmares have entered Sleepy's dream
    public float speed;
    public float spawnRadius;

    //public Queue<Transform> path = new Queue<Transform>();

    private Vector3 ychange = Vector3.zero;

    void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one instance of sleepy");
        }
        instance = this;
    }

    void Start()
    {

    }

    void Update()
    {
        if (Mathf.Abs(transform.position.y - ychange.y) < .05)     // If sleepy has moved close enough to the y max or min, update to new y change
        {
            RandomYChange();
        }
        transform.position += (Vector3.right + ychange/2) * speed * Time.deltaTime;
    }

    void RandomYChange()
    {
        if (ychange.y < 0)
            ychange = new Vector3(0, Random.Range(.75f, 1.25f), 0);
        else
            ychange = new Vector3(0, Random.Range(-1.25f, -.75f), 0);
    }
}
