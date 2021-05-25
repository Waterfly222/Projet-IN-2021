using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingFleuriste : MonoBehaviour
{
    public GameObject obj2follow;
    private Vector3 posRelat;
    // Start is called before the first frame update
    void Start()
    {
        posRelat = this.transform.position - obj2follow.transform.position;
        transform.position.Set(obj2follow.transform.position.x, obj2follow.transform.position.y, obj2follow.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = obj2follow.transform.position + posRelat;
    }
}
