using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSyringe : MonoBehaviour
{
    public AudioSource syringeFX;

    public void OnTriggerEnter(Collider other)
    {
        // Play audio
        syringeFX.Play();

        // Update counter
        CollectableController.syringeCount += 1;

        // Hide object
        this.gameObject.SetActive(false);
    }
}
