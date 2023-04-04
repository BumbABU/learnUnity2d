using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionPrefab : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject minionprefab;
    List<GameObject> Listminions = new List<GameObject>();
    protected float spawntimer =0f;
    protected float spawndeplay =1f;

    private void Awake()
    {
        this.minionprefab = GameObject.Find("Minion");
        this.minionprefab.SetActive(false);
    }
    private void Update()
    {
        
        
            SpawnminionPrefab();
        
        checkminionDead();
    }

    private void SpawnminionPrefab() // hàm này spawn ra những object con có những thuộc tính y chang object cha
    {
        this.spawntimer += Time.deltaTime;
        if (this.spawntimer < this.spawndeplay) return;
        this.spawntimer = 0;

       var index = Listminions.Count +1;
        if (this.Listminions.Count >= 7) return;
        GameObject minionPF = Instantiate(minionprefab);
        minionPF.name = "MinionPrefab" + index;
        minionPF.transform.position = this.transform.position;
        minionPF.gameObject.SetActive(true);  // set trạng thái là hoạt động cho dù bị ẩn đi
        Listminions.Add(minionPF);
    }

    void checkminionDead()
    {
        //GameObject minionDF;
        for (int i = 0; i < this.Listminions.Count; i++)
        {
           //minionDF = this.Listminions[i];
            if(/*minionDF == null*/ this.Listminions[i] == null) this.Listminions.RemoveAt(i);
        }
    }
}
