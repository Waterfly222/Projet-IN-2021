using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agent : MonoBehaviour
{
    public GameObject goal;

    private void Start()
    {
        GetComponent<NavMeshAgent>().destination = goal.transform.position;
    }
}
