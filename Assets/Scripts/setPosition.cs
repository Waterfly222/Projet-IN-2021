using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class setPosition : MonoBehaviour
{

    public GameObject pos1;
    public GameObject pos2;
    public GameObject arbre;
    public float distance = 0;

    private Vector3 pos = new Vector3(0, 0, -1);
    private Quaternion rota = Quaternion.Euler(0, 14, 0);
    private bool a=true;
    private bool b = true;
    private bool c = true;

    void Start()
    {
        GetComponent<NavMeshAgent>().destination = pos1.transform.position;
    }
    
    void Update()
    {
        if (a && GetComponent<NavMeshAgent>().enabled && GetComponent<NavMeshAgent>().remainingDistance < 0.1)
        {
            distance = GetComponent<NavMeshAgent>().remainingDistance;
            GetComponent<NavMeshAgent>().enabled = false;
            transform.parent = arbre.transform;
            transform.localPosition = pos;
            transform.localRotation = rota;
            transform.parent = null;
            GetComponent<Animator>().SetTrigger("CouperDuBois");
            pos = new Vector3(0, 0, 1);
            rota = Quaternion.Euler(0, 194, 0);
            a = false;
}
        if (b && arbre.GetComponent<arbre>().indexe == 40)
        {
            GetComponent<NavMeshAgent>().enabled = true;
            GetComponent<NavMeshAgent>().destination = pos2.transform.position;
            GetComponent<Animator>().SetTrigger("Marcher");
            a = true;
            b = false;
        }
        if (c&&arbre.GetComponent<arbre>().indexe == 100)
        {
            GetComponent<Animator>().SetTrigger("Idle");
            c = false;
        }
    }
}
