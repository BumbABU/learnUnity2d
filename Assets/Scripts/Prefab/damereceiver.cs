using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damereceiver : MonoBehaviour
{
    // Start is called before the first frame update
     public int hp;
     public int dame;

    public virtual void receiver()
    {
        this.hp -= dame;
    }
}
