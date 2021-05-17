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
        // init
        if(action == 0)
        {
            agent.destination = plant_target1.transform.position;
            animator.SetBool("move", true);
            animator.SetBool("noAction", true);
            animator.SetBool("holdingObject", false);
            action = 1;
        }
        // marche jusqu'au premier pot de fleur
        else if (action == 1)
        {
            if (agent.remainingDistance < 0.01f)
            {
                transform.rotation = plant_target1.transform.rotation;
                animator.SetBool("move", false);
                animator.SetBool("noAction", false);
                animator.SetTrigger("planting_seeds");
                action = 2;
            }
        }
        // plant dans le premier pot de fleur
        else if(action == 2)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("endplant"))
            {
                agent.destination = plant_target2.transform.position;
                animator.SetBool("move", true);
                animator.SetBool("noAction", true);
                action = 3;
            }
        }
        // marche jusqu'au deuxième pot de fleur
        else if (action == 3)
        {
            if (agent.remainingDistance < 0.01f)
            {
                transform.rotation = plant_target2.transform.rotation;
                animator.SetBool("move", false);
                animator.SetBool("noAction", false);
                animator.SetTrigger("planting_seeds");
                action = 4;
            }
        }
        // plant dans le deuxième pot de fleur
        else if (action == 4)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("endplant"))
            {
                agent.destination = watercan_target.transform.position;
                animator.SetBool("move", true);
                animator.SetBool("noAction", true);
                action = 5;
            }
        }
        // marche jusqu'à l'arrosoir
        else if (action == 5)
        {
            if (agent.remainingDistance < 0.01f)
            {
                transform.rotation = watercan_target.transform.rotation;
                animator.SetBool("move", false);
                animator.SetBool("noAction", false);
                animator.SetTrigger("pickup_watercan");
                action = 6;
            }
        }
        // récupère l'arrosoir
        else if (action == 6)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("endwatercan"))
            {
                agent.destination = fillwatercan_target.transform.position; //TODO mettre l'arrosoir dans la main et faire l'animation
                animator.SetBool("move", true);
                animator.SetBool("noAction", true);
                action = 7;
            }
        }
        // marche jusqu'au robinet
        else if (action == 7)
        {
            if (agent.remainingDistance < 0.01f)
            {
                transform.rotation = fillwatercan_target.transform.rotation;
                animator.SetBool("move", false);
                animator.SetBool("noAction", false);
                animator.SetTrigger("fill_watercan");
                action = 8;
            }
        }
        // rempli l'arrosoir
        else if (action == 8)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("endfillwatercan")) //TODO faire l'animation
            {
                agent.destination = plant_target1.transform.position;
                animator.SetBool("move", true);
                animator.SetBool("noAction", true);
                action = 9;
            }
        }
        // marche jusqu'au plant 1
        else if (action == 9)
        {
            if (agent.remainingDistance < 0.01f)
            {
                transform.rotation = plant_target1.transform.rotation;
                animator.SetBool("move", false);
                animator.SetBool("noAction", false);
                animator.SetTrigger("watering_plants");
                action = 10;
            }
        }
        // arrose le plant 1
        else if (action == 10)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("endwaterplants"))
            {
                agent.destination = plant_target2.transform.position;
                animator.SetBool("move", true);
                animator.SetBool("noAction", true);
                action = 11;
            }
        }
        // marche jusqu'au plant 2
        else if (action == 9)
        {
            if (agent.remainingDistance < 0.01f)
            {
                transform.rotation = plant_target2.transform.rotation;
                animator.SetBool("move", false);
                animator.SetBool("noAction", false);
                animator.SetTrigger("watering_plants");
                action = 10;
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
