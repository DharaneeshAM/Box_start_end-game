using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "player");
        {
            //GetComponent<MeshRenderer>().material.Albedo = Albedo.black;
            gameObject.tag="Hit";
        }
    }    
}
