using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableController : MonoBehaviour
{
    // Init count
    public static int syringeCount = 0;

    // Get Reference to counter
    public GameObject syringeCounterDisplay;
    public GameObject syringeEndDisplay;

    // Update is called once per frame
    void Update()
    {
        // Update counter display
        syringeCounterDisplay.GetComponent<Text>().text = "" + syringeCount;
        syringeEndDisplay.GetComponent<Text>().text = "" + syringeCount;
    }
}
