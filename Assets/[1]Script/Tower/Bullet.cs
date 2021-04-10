using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed;
    public GameObject target;
    public int Damage;
    void Update()
    {
        if (target == null) return;

        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed*Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == target)
        {
            target.GetComponent<Enemy>().ChangeHealth(-Damage);
            Destroy(gameObject);
        }
    }
}
