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
    public GameObject hache;

    public int indexe=0;
    public int indexePrec = 0;
    private bool isShooting = false;
    private int nbCoups = 9;

    /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */

    void OnTriggerEnter(Collider other)
    {
        indexe++;
        //print(indexe);
    }

    private void Start()
    {
        GetComponent<ParticleSystem>().Stop();
        //print(indexe);
    }

    void Update()
    {
        if (!isShooting && indexe != indexePrec)
        {
            GetComponent<ParticleSystem>().Play();
            isShooting = true;
            indexePrec++;
        }
        if(indexe == indexePrec)
        {
            isShooting = false;
        }

        if (indexe== nbCoups)
        {
            arbre0.SetActive(false);
            arbre1.SetActive(true);
        }
        if (indexe == nbCoups*2)
        {
            arbre1.SetActive(false);
            arbre2.SetActive(true);
        }
        if (indexe == nbCoups*3)
        {
            arbre2.SetActive(false);
            arbre3.SetActive(true);
        }
        if (indexe == nbCoups*4)
        {
            arbre3.SetActive(false);
            arbre4.SetActive(true);
        }
        if (indexe == nbCoups*5)
        {
            arbre4.SetActive(false);
            arbre5.SetActive(true);
        }
        if (indexe == nbCoups*6)
        {
            arbre5.SetActive(false);
            arbre6.SetActive(true);
        }
        if (indexe == nbCoups*7)
        {
            arbre6.SetActive(false);
            arbre7.SetActive(true);
        }
        if (indexe == nbCoups*8)
        {
            arbre7.SetActive(false);
            arbre8.SetActive(true);
        }
        if (indexe == nbCoups*9)
        {
            arbre8.SetActive(false);
            arbre9.SetActive(true);
        }
        if (indexe == nbCoups*10)
        {
            Destroy(hache.GetComponent<Rigidbody>());
            Destroy(hache.GetComponent<BoxCollider>());
            arbre9.SetActive(false);
            arbre10.SetActive(true);
            GetComponent<AudioSource>().Play();
            indexe++;
        }
    }
}
