using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEndAnimCamera2 : MonoBehaviour
{
    public GameObject boutonFleuriste;
    public GameObject boutonBucheron;
    public GameObject boutonTondeur;
    public GameObject boutonSerre;
    public GameObject boutonVueEnsemble;
    public GameObject flowerman;
    public GameObject bucheron;
    public GameObject tondeur;
    public GameObject serreman;

    private bool a = true;

    // Update is called once per frame
    void Update()
    {
        if (a && GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("end_anim_2") )
        {
            boutonFleuriste.SetActive(true);
            boutonBucheron.SetActive(true);
            boutonTondeur.SetActive(true);
            boutonSerre.SetActive(true);
            boutonVueEnsemble.SetActive(true);
            flowerman.SetActive(true);
            tondeur.SetActive(true);
            bucheron.SetActive(true);
            serreman.SetActive(true);
            a = false;
        }
    }
}
