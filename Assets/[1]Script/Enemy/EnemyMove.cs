using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : Enemy
{
    protected Vector3[] PathDinamic;

    void Start()
    {
        OnReady+= OnReadySetPath;
    }

    void OnReadySetPath()
    {
        PathDinamic = Path;
    }

    void Update()
    {
        
    }
}
