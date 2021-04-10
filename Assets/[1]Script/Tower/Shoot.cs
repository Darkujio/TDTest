using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]TowerMain TowerMain;
    [SerializeField]GameObject BulletPrefab;

    int Damage;
    int Radius;
    float ShootDelay;
    Vector2 TowerPos;

    void Awake()
    {
        TowerMain.StatsChanged += GetStats;
        TowerMain.ReadyToShoot += Init;
    }
    void GetStats()
    {
        Damage = TowerMain.Damage;
        ShootDelay = TowerMain.ShootInterval;
        Radius = TowerMain.Radius;
    }
    void Init()
    {
        TowerPos = transform.position;
        StartCoroutine(ShootTimer(ShootDelay));
    }

    IEnumerator ShootTimer(float Delay)
    {
        CheckBullet();
        yield return new WaitForSeconds(Delay);
        StartCoroutine(ShootTimer(Delay));
    }

    void CheckBullet()
    {
        LayerMask enemy = 1 << 10;
        Collider2D [] colliders = Physics2D.OverlapCircleAll(TowerPos, Radius, enemy);
        if(colliders.Length > 0)
        {
            float PrevDist = Mathf.Infinity;
            GameObject target = null;
            foreach (Collider2D col in colliders)
            {
                List<Vector3> PathDinamic = col.GetComponent<EnemyMove>().PathDinamic;
                Vector3 LastPoint = PathDinamic[PathDinamic.Count-1];
                float Dist = Vector3.Distance(col.gameObject.transform.position, LastPoint);
                if (Dist < PrevDist)
                {
                    PrevDist = Dist;
                    target = col.gameObject;
                }
            }
            SendBullet(target);
        }
        
    }
    void SendBullet(GameObject target)
    {
        GameObject bullet = Instantiate(BulletPrefab, transform.position, Quaternion.identity);
        Bullet BulletData = bullet.GetComponent<Bullet>();
        BulletData.target = target;
        BulletData.Damage = Damage;
    }
}
