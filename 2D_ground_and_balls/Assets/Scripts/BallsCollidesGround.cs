using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsCollidesGround : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CCCC1");
        //Debug.Log(other.gameObject.name);
        //BallCondition ball = other.gameObject.GetComponent<BallCondition>();

        //if (ball != null)
        //{
        //    //Destroy(other.gameObject); // destroy ovcu
        //    //sheep.DestroySheep(); //vizivaem metod iz Scripta Sheep
        //    //sheep.gameObject.SetActive(false);
        //    Debug.Log("Collison Occured");

        //}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("CCCC");
    }
}

