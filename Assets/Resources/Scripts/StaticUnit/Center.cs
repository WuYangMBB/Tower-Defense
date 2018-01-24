using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Center : StaticUnit{

    public GameObject soldier;
    public GameObject hero;
    public Transform spawnPoint;
    public float spawnCoolDown;

    private float timer;

	void Start ()
    {
        SpawnSoldier();
    }
	
	void Update ()
    {
        timer += Time.deltaTime;
        if (timer >= spawnCoolDown)
        {
            SpawnSoldier();
            timer = 0;
        }
    }

    void SpawnSoldier ()
    {
        Instantiate(soldier, spawnPoint.position, spawnPoint.rotation);
    }

    void SpawnHero ()
    {
        Instantiate(hero, spawnPoint.position, spawnPoint.rotation);
    }

}

