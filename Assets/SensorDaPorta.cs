using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorDaPorta : MonoBehaviour
{
    public Animator porta;
    public Material corQuePode;
    private void OnTriggerEnter(Collider other)
    {
        
        if ((other.CompareTag("Player")) || ((other.GetComponent<MeshRenderer>().materials[0].color.Equals(corQuePode.color))))
        {
            porta.SetBool("aberta", true);
        }        
    }

    private void OnTriggerExit(Collider other)
    {
        if ((other.CompareTag("Player")) || ((other.GetComponent<MeshRenderer>().materials[0].color.Equals(corQuePode.color))))
        {
            porta.SetBool("aberta", false);
        }
    }
}
