using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INIT : MonoBehaviour
{
    [SerializeField]EnemyFabric EnemyFabric;
    void Start()
    {
        EnemyFabric.Init();
    }
}
