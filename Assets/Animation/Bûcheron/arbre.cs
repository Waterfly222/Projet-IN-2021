using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arbre : MonoBehaviour
{
    public GameObject arbre0;
    public GameObject arbre1;
    public GameObject arbre2;
    public GameObject arbre3;
    public GameObject arbre4;
    public GameObject arbre5;
    public GameObject arbre6;
    public GameObject arbre7;
    public GameObject arbre8;
    public GameObject arbre9;
    public GameObject arbre10;

    private int indexe=0;

    /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */

    void OnTriggerEnter(Collider other)
    {
        indexe++;
        print(indexe);
    }

    private void Start()
    {
        print(indexe);
    }

    void Update()
    {
        if (indexe==10)
        {
            arbre0.SetActive(false);
            arbre1.SetActive(true);
        }
        if (indexe == 20)
        {
            arbre1.SetActive(false);
            arbre2.SetActive(true);
        }
        if (indexe == 30)
        {
            arbre2.SetActive(false);
            arbre3.SetActive(true);
        }
        if (indexe == 40)
        {
            arbre3.SetActive(false);
            arbre4.SetActive(true);
        }
        if (indexe == 50)
        {
            arbre4.SetActive(false);
            arbre5.SetActive(true);
        }
        if (indexe == 60)
        {
            arbre5.SetActive(false);
            arbre6.SetActive(true);
        }
        if (indexe == 70)
        {
            arbre6.SetActive(false);
            arbre7.SetActive(true);
        }
        if (indexe == 80)
        {
            arbre7.SetActive(false);
            arbre8.SetActive(true);
        }
        if (indexe == 90)
        {
            arbre8.SetActive(false);
            arbre9.SetActive(true);
        }
        if (indexe == 100)
        {
            arbre9.SetActive(false);
            arbre10.SetActive(true);
        }
    }
}
