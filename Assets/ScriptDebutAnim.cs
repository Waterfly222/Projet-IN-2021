using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDebutAnim : MonoBehaviour
{
    public GameObject flowerman;
    public GameObject tondeur;
    public GameObject bucheron;
    public GameObject serreman;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("truck"))
        {
            print("test");
            flowerman.SetActive(true);
            tondeur.SetActive(true);
            bucheron.SetActive(true);
            serreman.SetActive(true);
        }
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
