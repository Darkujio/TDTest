using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyMove : MonoBehaviour
{
    public List<Vector3> PathDinamic;
    protected int Speed;
    bool Ready = false;

    private Enemy enemy;

    void Awake()
    {
        enemy = gameObject.GetComponent<Enemy>();
        enemy.OnReady += OnReadySetPath;
    }

    void OnReadySetPath()
    {
        PathDinamic = enemy.Path;
        Speed = enemy.Speed;
        Ready = true;
    }

    void Update()
    {
        if (Ready) FollowPath();
    }

    void FollowPath()
    {
        transform.position = Vector3.MoveTowards(transform.position, PathDinamic[0], Speed*Time.deltaTime);
        if (Vector3.Distance(transform.position, PathDinamic[0]) < 0.01f) PathDinamic.RemoveAt(0);
    }
}
