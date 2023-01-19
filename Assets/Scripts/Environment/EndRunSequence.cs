using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRunSequence : MonoBehaviour
{
    
    public GameObject liveSerynges;
    public GameObject endScreen;
    public GameObject FadeOut;

    void Start()
    {
        StartCoroutine(EndSequence());
    }

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(2);
        liveSerynges.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(2);
        FadeOut.SetActive(true);
    }
}
