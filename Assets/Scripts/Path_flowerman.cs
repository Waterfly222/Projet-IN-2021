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
    public GameObject truck_target;

    // others
    public GameObject watercan;
    public ParticleSystem effet_eau;
    public GameObject main;
    public GameObject bouton;
    Animator animator;
    private NavMeshAgent agent;
    int action;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        effet_eau.Stop();
        action = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // init
        if (action == 0)
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
            if (agent.remainingDistance < 0.01f && !GetComponent<NavMeshAgent>().pathPending)
            {
                transform.rotation = plant_target1.transform.rotation;
                animator.SetBool("move", false);
                animator.SetBool("noAction", false);
                animator.SetTrigger("planting_seeds");
                action = 2;
            }
        }
        // plant dans le premier pot de fleur
        else if (action == 2)
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
            if (agent.remainingDistance < 0.01f && !GetComponent<NavMeshAgent>().pathPending)
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
            if (agent.remainingDistance < 0.01f && !GetComponent<NavMeshAgent>().pathPending)
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
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("pickup_watercan2"))
            {
                watercan.transform.SetParent(main.transform);
                watercan.transform.localPosition = new Vector3(-0.08636265f, 0.3135328f, 0.07620765f);
                watercan.transform.localRotation = Quaternion.Euler(-262.872f, 27.98999f, 21.60699f);
                action = 7;
            }
        }
        // fin animation récupération arrosoir
        else if (action == 7)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("endwatercan"))
            {
                agent.destination = fillwatercan_target.transform.position;
                animator.SetBool("move", true);
                animator.SetBool("noAction", true);
                animator.SetBool("holdingObject", true);
                action = 8;
            }
        }
        // marche jusqu'au robinet
        else if (action == 8)
        {
            if (agent.remainingDistance == 0 && !GetComponent<NavMeshAgent>().pathPending)
            {
                transform.rotation = fillwatercan_target.transform.rotation;
                animator.SetBool("move", false);
                animator.SetBool("noAction", false);
                animator.SetTrigger("fill_watercan");
                action = 9;
            }
        }
        else if (action == 9)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("fill_watercan2"))
            {
                effet_eau.Play();
                action = 10;
            }
        }
        else if (action == 10)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("fill_watercan3"))
            {
                effet_eau.Stop();
                action = 11;
            }
        }

        else if (action == 11)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("endfillwatercan"))
            {
                agent.destination = plant_target1.transform.position;
                animator.SetBool("move", true);
                animator.SetBool("noAction", true);
                action = 12;
            }
        }
        // marche jusqu'au plant 1
        else if (action == 12)
        {
            if (agent.remainingDistance < 0.01f && !GetComponent<NavMeshAgent>().pathPending)
            {
                transform.rotation = plant_target1.transform.rotation;
                animator.SetBool("move", false);
                animator.SetBool("noAction", false);
                animator.SetTrigger("watering_plants");
                action = 13;
            }
        }
        // arrose le plant 1
        else if (action == 13)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("endwaterplants"))
            {
                agent.destination = plant_target2.transform.position;
                animator.SetBool("move", true);
                animator.SetBool("noAction", true);
                action = 14;
            }
        }
        // marche jusqu'au plant 2
        else if (action == 14)
        {
            if (agent.remainingDistance < 0.01f && !GetComponent<NavMeshAgent>().pathPending)
            {
                transform.rotation = plant_target2.transform.rotation;
                animator.SetBool("move", false);
                animator.SetBool("noAction", false);
                animator.SetTrigger("watering_plants");
                action = 15;
            }
        }
        else if (action == 15)
        {
            print(action);
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("endwaterplants"))
            {
                agent.destination = truck_target.transform.position;
                animator.SetBool("move", true);
                animator.SetBool("noAction", true);
                action = 16;
            }
        }
        else if (action == 16)
        {
            if (agent.remainingDistance < 0.01f && !GetComponent<NavMeshAgent>().pathPending)
            {
                Destroy(gameObject);
                Destroy(bouton);
            }
        }

    }
}
