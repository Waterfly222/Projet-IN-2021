using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingSerreMan : MonoBehaviour
{
    public GameObject obj2follow;
    public float x;
    public float y;
    public float z;


    // Update is called once per frame
    public void appuyer()
    {
        GetComponent<Animator>().enabled = false;
        Vector3 decalage = new Vector3(x, y, z);
        GetComponent<FollowingCamera>().obj2follow = obj2follow;
        GetComponent<FollowingCamera>().posRelat = decalage;
        this.transform.position = obj2follow.transform.position + decalage;
        transform.LookAt(obj2follow.transform);
    }
}
