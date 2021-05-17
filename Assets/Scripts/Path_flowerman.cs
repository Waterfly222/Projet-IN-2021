// Guillaume ROBERT

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Path_flowerman : MonoBehaviour
{
    // waypoint
    public GameObject plant_target1;
    public GameObject plant_target2;
    public GameObject watercan_target;
    public GameObject fillwatercan_target;

    // others
    public GameObject watercan;
    public GameObject main;
    Animator animator;
    private NavMeshAgent agent;
    int action;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        action = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(action == 0)
        {
            agent.destination = plant_target1.transform.position;
            animator.SetBool("move", true);
            animator.SetBool("onTarget", false);
            animator.SetBool("hasObject", false);
            animator.SetBool("watercan", false);
            action = 1;
        }
        else if (action == 1)
        {
            if (agent.remainingDistance < 0.01f)
            {
                transform.rotation = plant_target1.transform.rotation;
                animator.SetBool("move", false);
                animator.SetBool("onTarget", true);
                action = 2;
            }
        }
        else if(action == 2)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("endplant"))
            {
                agent.destination = plant_target2.transform.position;
                animator.SetBool("move", true);
                animator.SetBool("onTarget", false);
                action = 3;
            }
        }
        else if(action == 3)
        {
            if (agent.remainingDistance < 0.01f)
            {
                transform.rotation = plant_target2.transform.rotation;
                animator.SetBool("move", false);
                animator.SetBool("onTarget", true);
                action = 4;
            }
        }
        else if(action == 4)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("endplant"))
            {
                agent.destination = watercan_target.transform.position;
                animator.SetBool("move", true);
                animator.SetBool("onTarget", false);
                action = 5;
            }
        }
        else if (action == 5)
        {
            if (agent.remainingDistance < 0.01f)
            {
                transform.rotation = watercan_target.transform.rotation;
                animator.SetBool("move", false);
                animator.SetBool("onTarget", true);
                animator.SetBool("watercan", true);
                action = 6;
            }
        }
        /*
        if ((agent.destination == plant_target1.transform.position ||
            agent.destination == plant_target2.transform.position) &&
            agent.remainingDistance < 0.25f)
        {
            animator.SetBool("move", false);
            animator.SetBool("onTarget", true);
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("plant_seeds"))
        {
            animator.SetBool("onTarget", false);
            if(agent.destination == plant_target1.transform.position && animator.GetCurrentAnimatorStateInfo(0).)
            {

            }
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("pickup_watercan"))
        {
            watercan.transform.SetParent(main.transform);
            Quaternion rotationWatercan = new Quaternion();
            rotationWatercan.eulerAngles = new Vector3(-176.524f, 4.9993988f, 9.585999f);
            arrosoir.transform.SetPositionAndRotation(new Vector3(-0.028f,0.292f,0.041f), rotationWatercan);
        }*/

    }
}
