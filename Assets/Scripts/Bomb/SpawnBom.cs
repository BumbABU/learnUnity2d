using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBom : MonoBehaviour
{
    // Start is called before the first frame update
    private List<GameObject> bomList;
    public GameObject bomprefab;
    protected float spawntimer = 0f;
    protected float spawndeplay = 1f;

    private void Start()
    {
        this.bomList = new List<GameObject>();
    }

    private void Update()
    {
       spawn_Bom();

        check_bomDead();
    }

    private void spawn_Bom()
    {
        this.spawntimer += Time.deltaTime;
        if (this.spawntimer < this.spawndeplay) return;
        this.spawntimer = 0f;

        if (bomList.Count >= 7) return;
        var index = this.bomList.Count +1;
        GameObject bom = Instantiate(bomprefab);
        bom.name = "Bom #" + index;
        bom.transform.position = this.transform.position;
        bomList.Add(bom);
        bom.gameObject.SetActive(true);
        

    }

    private void check_bomDead()
    {
        GameObject newbom;
        for (int i = 0; i < this.bomList.Count; i++)
        {
            Debug.Log(i);
            newbom = bomList[i];
            if (newbom == null) this.bomList.RemoveAt(i);
        }

        
    }
}
