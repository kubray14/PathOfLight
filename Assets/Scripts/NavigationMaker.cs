using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationMaker : MonoBehaviour
{
    [SerializeField] NavMeshSurface bake;

    private void Start()
    {
        bake.BuildNavMesh();
    }
    public void navMeshBake()
    {
        bake.BuildNavMesh();
    }
}
