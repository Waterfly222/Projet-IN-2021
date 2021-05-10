using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Path_flowerman : MonoBehaviour
{
    public GameObject Cible;
    Animator animator;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = Cible.transform.position;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance < 0.25f)
        {
            animator.SetBool("move", false);
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("dig_and_plant_seed"))
        {
            animator.SetBool("plant", false);
        }
    }
}
