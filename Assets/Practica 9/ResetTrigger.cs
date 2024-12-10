using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTrigger : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lata")) 
        {
            Rigidbody lataRigidbody = other.GetComponent<Rigidbody>();

            if (lataRigidbody != null)
            {
               
                lataRigidbody.velocity = Vector3.zero;
                lataRigidbody.angularVelocity = Vector3.zero;

                
                other.transform.position = spawnPoint.transform.position;
                other.transform.rotation = spawnPoint.transform.rotation;
            }
        }
    }
}