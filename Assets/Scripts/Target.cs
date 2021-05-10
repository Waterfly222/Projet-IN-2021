using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{
    public GameObject Cible;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<NavMeshAgent>().destination = Cible.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
