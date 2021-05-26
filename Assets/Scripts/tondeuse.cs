using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tondeuse : MonoBehaviour
{
    public GameObject tondeur;
    private bool a = true;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("herbe")) Destroy(other.gameObject);
    }

    void Start()
    {
        GetComponent<ParticleSystem>().Stop();
    }

    void Update()
    {
        if (tondeur.activeSelf)
        {
            if (a && tondeur.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("walkingAvecTondeuse"))
            {
                GetComponent<ParticleSystem>().Play();
                GetComponent<AudioSource>().Play();
                a = false;
            }
            if (!tondeur.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("walkingAvecTondeuse"))
            {
                GetComponent<ParticleSystem>().Stop();
                GetComponent<AudioSource>().Stop();
            }
        }
    }
}
