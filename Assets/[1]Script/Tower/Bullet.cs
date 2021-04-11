using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed;
    public GameObject target;
    public int Damage;
    void LateUpdate()
    {
        if (target == null) Destroy(gameObject);
        else transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed*Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == target)
        {
            gameObject.SetActive(false);
            target.GetComponent<Enemy>().ChangeHealth(-Damage);
        }
    }
}
