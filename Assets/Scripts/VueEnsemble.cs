using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VueEnsemble : MonoBehaviour
{
    public GameObject obj2follow;
    public float x;
    public float y;
    public float z;


    // Update is called once per frame
    public void appuyer()
    {
        transform.parent = null;
        GetComponent<Animator>().enabled = false;
        Vector3 decalage = new Vector3(x, y, z);
        this.transform.position = obj2follow.transform.position + decalage;
        transform.parent = obj2follow.transform;
        transform.LookAt(obj2follow.transform);
    }
}
