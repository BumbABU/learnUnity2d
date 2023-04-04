using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damesender : MonoBehaviour
{
    public EnemyCtrl enemyCtrl;

    private void Awake()
    {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        damereceiver Damereceiver = collision.GetComponent<damereceiver>();
        // hàm get component là hàm để tạo 1 sự liên kết giữa 2object và 2 script
       
        /*if (Damereceiver.hp <= 0) return;*/
        Damereceiver.receiver();

        this.enemyCtrl.despawner.Destroyenemy();
        Debug.Log(collision.gameObject.name);

    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }*/
}
