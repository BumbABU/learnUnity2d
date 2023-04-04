using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour
{
    // Start is called before the first frame update
   public virtual void Destroyenemy ()
    {
        Destroy(gameObject);
    }
}
