using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsCollidesGround : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
        //BallCondition ball = other.gameObject.GetComponent<BallCondition>();

        //if (ball != null)
        //{
        //    //Destroy(other.gameObject); // destroy ovcu
        //    //sheep.DestroySheep(); //vizivaem metod iz Scripta Sheep
        //    //sheep.gameObject.SetActive(false);
        //    Debug.Log("Collison Occured");

        //}
    }
}
