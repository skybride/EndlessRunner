using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; //a reference to players position
    public Vector3 offset;//store 3 floats for positional data

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset; //lower case transfrom refers to the component that has this script attached (the camera)
    }
}
