using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorArmadilha : MonoBehaviour
{
    public Animator animator;
    public Rigidbody[] objetoGravitacional;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger("vai");
        }
    }

    public void ativarGravidae()
    {
        foreach (Rigidbody item in objetoGravitacional)
        {
            item.useGravity = true;
        }
        
    }
}
