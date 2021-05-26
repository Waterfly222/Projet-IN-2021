using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SerreMan : MonoBehaviour
{
    public GameObject cible;
    public GameObject plant;
    public Transform currentCible;
    public GameObject porte;
    private int indiceCible = 1;
    private bool a = true;
    private bool planter = false;

    void Start()
    {
        string tmp = "Cible" + indiceCible;
        //print(tmp);
        currentCible = cible.transform.Find(tmp);
        GetComponent<NavMeshAgent>().destination = currentCible.position;
    }
    void LateUpdate()
    {
        planter = GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("planter");

        if (a && GetComponent<NavMeshAgent>().remainingDistance < 0.05 && !GetComponent<NavMeshAgent>().pathPending)
        {
            if (indiceCible == 13)
            {
                Destroy(gameObject);
            }
            porte.GetComponent<ConstantForce>().relativeForce = new Vector3(-1, 0, 0);
            indiceCible++;
            GetComponent<NavMeshAgent>().enabled = false;
            transform.SetPositionAndRotation(new Vector3(currentCible.position.x, transform.position.y, currentCible.position.z), currentCible.rotation);
            GetComponent<Animator>().SetTrigger("Planter");
            a = false;
            string tmp = "Cible" + indiceCible;
            currentCible = cible.transform.Find(tmp);
            planter = true;
        }
        if (!planter)
        {
            string tmp = "plant" + (indiceCible-1);
            Transform currentPlant = plant.transform.Find(tmp);
            if (currentPlant != null)
            {
                currentPlant.gameObject.SetActive(true);
            }
            a = true;
            GetComponent<NavMeshAgent>().enabled = true;
            GetComponent<NavMeshAgent>().destination = currentCible.position;
        }

            /*
            print(tmp);
            */        
    }
}
