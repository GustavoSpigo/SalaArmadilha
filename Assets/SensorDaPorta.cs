using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorDaPorta : MonoBehaviour
{
    public Animator porta;
    public Material corQuePode;
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            porta.SetBool("aberta", true);
        }        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            porta.SetBool("aberta", false);
        }
    }
}
