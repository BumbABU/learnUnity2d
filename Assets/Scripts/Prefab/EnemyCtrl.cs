using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    public Despawner despawner;

    private void Awake()
    {
        this.despawner= GetComponent<Despawner>();
    }
}
