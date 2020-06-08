using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject demon;
    public GameObject physical;
    public GameObject goo;

    private Sleepy sleepy;
    private Player player;

    private int nightmares;
    private float time;

    private int score;

    private float spawnDelay;

    IEnumerator Start()
    {
        sleepy = Sleepy.instance;
        player = Player.instance;
        nightmares = 0;
        time = 0f;
        score = 0;
        spawnDelay = 3f;

        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);
            Debug.Log("Spawned enemy");
            SpawnNightmare();
        }
    }

    void Update()
    {
        time += Time.deltaTime;
    }

    void SpawnNightmare()
    {
        nightmares++;

        float nightmareXSpawn = Random.Range((sleepy.transform.position.x - sleepy.spawnRadius), (sleepy.transform.position.x + sleepy.spawnRadius));
        Debug.Log("X spawn: " + nightmareXSpawn);

        //(𝑥−𝑢)2+(𝑦−𝑣)2=𝑟2
        //𝑦=𝑣±𝑟2−(𝑥−𝑢)2
        float u = sleepy.transform.position.x;
        float v = sleepy.transform.position.y;
        float nightmareYSpawn = v + Mathf.Sqrt(Mathf.Pow(sleepy.spawnRadius, 2) - Mathf.Pow(nightmareXSpawn - u, 2));
        Debug.Log("Y spawn: " + nightmareYSpawn);

        if ((nightmares % 2).Equals(0))
            nightmareYSpawn = 0 - nightmareYSpawn;
        Debug.Log("Y spawn: " + nightmareYSpawn);

        GameObject d = GameObject.Instantiate(demon, new Vector3(nightmareXSpawn, nightmareYSpawn, 0), new Quaternion(0, 0, 0, 0));
        d.GetComponent<Nightmare>().sleepy = sleepy.transform;
    }
}
