using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayer : MonoBehaviour
{
    
    // Start is called before the first frame update
    public Transform Player;
    [SerializeField] private float speed;
    [SerializeField] private float distancelimit;
    private void Update()
    {
        Vector3 distance = Player.transform.position - transform.position;
        if (distance.magnitude >= distancelimit)
        {
            Vector3 targetPoint = Player.transform.position - distance.normalized * distancelimit;
            gameObject.transform.position =
                Vector3.MoveTowards(gameObject.transform.position, targetPoint, this.speed * Time.deltaTime);
        }
    }

}
