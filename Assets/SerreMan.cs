using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SerreMan : MonoBehaviour
{
    public GameObject cible;
    private float initial_speed;

    void Start()
    {
        GetComponent<NavMeshAgent>().destination = cible.transform.position;
        initial_speed = GetComponent<NavMeshAgent>().speed;
    }
    void Update()
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Ouverture Porte"))
        {
            //GetComponent<NavMeshAgent>().speed = 0;
        }
        else
        {
            //GetComponent<NavMeshAgent>().speed = initial_speed/2;
        }
    }
}
