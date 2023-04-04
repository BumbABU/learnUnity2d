using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    // Update is called once per frame
    List<GameObject> listobj = new List<GameObject>();
    private void Update()
    {
        if (this.transform.position.x >= 7)
        {
            spawn();
        }
       
    }

    void spawn() // hàm này chỉ spawn ra object con và không có thuộc tính của object cha
    {
        if (this.listobj.Count >= 7) return;
        int index = listobj.Count + 1;
        GameObject obj = new GameObject("Minion" + index);
        listobj.Add(obj);



    }

}
