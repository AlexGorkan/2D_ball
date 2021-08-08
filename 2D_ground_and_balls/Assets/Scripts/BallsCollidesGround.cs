using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsCollidesGround : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        //BallCondition ball = other.gameObject.GetComponent<BallCondition>();

        //if (ball != null)
        //{
        //    Debug.Log("Collison");

        //}
    }
    
}
