using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    public GameObject obj2follow;
    public Vector3 posRelat = new Vector3(0,0,0);

    // Update is called once per frame
    void Update()
    {
        if (obj2follow != null)
        {
            this.transform.position = obj2follow.transform.position + posRelat;
        }
    }
}
