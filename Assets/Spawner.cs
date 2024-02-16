using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;
    [SerializeField] float timeBetweenSpawns;
    float spawnElapsed = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spawnElapsed += Time.deltaTime;

        if(spawnElapsed >= timeBetweenSpawns)
        {
            //Spawn();
            spawnElapsed = 0;
        }
    }

    private void Spawn()
    {
        GameObject g = Instantiate(playerPrefab);
        int r = Random.Range(-5, 5);
        g.transform.position = new Vector3(r, r, r);
        Destroy(g.gameObject, 1);
    }
}
