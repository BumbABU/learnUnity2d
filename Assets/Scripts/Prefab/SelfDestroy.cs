using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy1", 10f);
    }

    // Update is called once per frame
   void Destroy1()
    {
        Destroy(gameObject); 
    }
}
