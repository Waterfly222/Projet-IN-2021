using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowingTruck : MonoBehaviour
{
    public GameObject obj2follow;
    private Vector3 posRelat;
    int cpt;
    // Start is called before the first frame update
    void Start()
    {
        posRelat = this.transform.position - obj2follow.transform.position;
        cpt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = obj2follow.transform.position + posRelat;
        if (cpt > 0 && obj2follow.GetComponent<NavMeshAgent>().pathEndPosition.x == obj2follow.transform.position.x)
        {
            Debug.Log("passe");
            GetComponent<Animator>().enabled = true;
            GetComponent<Animator>().SetTrigger("retourne");
        }
        if (cpt == 0) cpt++;
    }
}
