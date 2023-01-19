using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSyringe : MonoBehaviour
{
    public AudioSource syringeFX;
    public GameObject levelControl;

    public void OnTriggerEnter(Collider other)
    {
        // Play audio
        syringeFX.Play();

        // Update counter
        CollectableController.syringeCount += 1;

        if(CollectableController.syringeCount == 3)
        {
            levelControl.GetComponent<VictoryEndRunSequence>().enabled = true;
        }

        // Hide object
        this.gameObject.SetActive(false);
    }
}
