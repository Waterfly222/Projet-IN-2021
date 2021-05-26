using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class tondeur : MonoBehaviour
{
    public GameObject posTondre;
    public GameObject posFinTondre;
    public float distance = 0;

    private bool a = true;
    private bool b = true;
    private Vector3 pos = new Vector3(0, 0.35f, 3.5f);
    private Quaternion rota = Quaternion.Euler(0, 180, 0);

    void Start()
    {
        GetComponent<NavMeshAgent>().destination = posTondre.transform.position;
    }

    void Update()
    {
        if (!a && GetComponent<NavMeshAgent>().enabled && GetComponent<NavMeshAgent>().remainingDistance < 1 && GetComponent<NavMeshAgent>().destination == posFinTondre.transform.position)
        {
            GetComponent<Animator>().SetTrigger("Idle");
        }
        if (a && GetComponent<NavMeshAgent>().enabled && GetComponent<NavMeshAgent>().remainingDistance < 0.1)
        {
            distance = GetComponent<NavMeshAgent>().remainingDistance;
            GetComponent<NavMeshAgent>().enabled = false;
            GetComponent<NavMeshAgent>().speed = 1;
            transform.parent = posTondre.transform.parent;
            transform.localPosition = pos;
            transform.localRotation = rota;
            transform.parent = null;
            posTondre.transform.parent.transform.parent = transform;
            GetComponent<Animator>().SetTrigger("Tondre");
            a = false;
        }
        if (b && GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("walkingAvecTondeuse"))
        {
            GetComponent<NavMeshAgent>().enabled = true;
            GetComponent<NavMeshAgent>().destination = posFinTondre.transform.position;
            b = false;
        }
        
    }
}
