using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    public GameObject obj2follow;

    private Vector3 posRelat;
    // Start is called before the first frame update
    void Start()
    {
        posRelat = this.transform.position - obj2follow.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = obj2follow.transform.position + posRelat;
    }
}
