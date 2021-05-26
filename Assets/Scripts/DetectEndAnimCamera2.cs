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
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("end_anim_2"))
        {
            boutonFleuriste.SetActive(true);
            boutonBucheron.SetActive(true);
            boutonTondeur.SetActive(true);
            boutonSerre.SetActive(true);
            boutonVueEnsemble.SetActive(true);
        }
    }
}
