using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampolin : MonoBehaviour
{
    public float force = 10;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "trampolin")
        {
            Debug.Log("TRAMPOSALTO");
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * force);
        }  
    }
}
