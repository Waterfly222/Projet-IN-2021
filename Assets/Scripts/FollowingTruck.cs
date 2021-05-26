using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowingTruck : MonoBehaviour
{
    public GameObject obj2follow;
    private Vector3 posRelat;
    private bool pasArrivee;
    // Start is called before the first frame update
    void Start()
    {
        posRelat = this.transform.position - obj2follow.transform.position;
        pasArrivee = true;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = obj2follow.transform.position + posRelat;
        if (!obj2follow.GetComponent<NavMeshAgent>().pathPending && pasArrivee && obj2follow.GetComponent<NavMeshAgent>().pathEndPosition.x == obj2follow.transform.position.x)
        {
            GetComponent<Animator>().enabled = true;
            GetComponent<Animator>().SetTrigger("retourne");
            pasArrivee = false;
            GetComponent<FollowingTruck>().enabled = false;
        }
    }
}
