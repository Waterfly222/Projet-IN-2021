using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptFin : MonoBehaviour
{
    public GameObject textFin;
    void OnTriggerEnter(Collider other)
    {
        textFin.SetActive(true);
    }
}
