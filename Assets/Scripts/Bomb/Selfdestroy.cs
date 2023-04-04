using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selfdestroy : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Invoke("Destroy", 12f);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
