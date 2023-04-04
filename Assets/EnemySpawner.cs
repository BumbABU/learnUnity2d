using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    protected GameObject enemyprefab;
    protected float Spawntimer = 0;
    protected float Spawndeplay = 3;
    private void Awake()
    {
        this.enemyprefab = GameObject.Find("Enemiesprefab");
        this.enemyprefab.SetActive(false);
    }

    private void Update()
    {
        SpawnEnemy();
    }
    private void SpawnEnemy()
    {
     

        this.Spawntimer += Time.deltaTime;
        if (this.Spawntimer < this.Spawndeplay) return;
        this.Spawntimer = 0;
        GameObject enemyprefabs = Instantiate(enemyprefab);
        enemyprefabs.SetActive(true);
        enemyprefabs.transform.position = this.transform.position;

    }
}
