using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryEndRunSequence : MonoBehaviour
{

    public GameObject player;
    public GameObject serynges;
    public GameObject victoryScreen;

    void Start()
    {
        StartCoroutine(VictoryEndSequence());
    }

    IEnumerator VictoryEndSequence()
    {
        player.GetComponent<PlayerMove>().enabled = false;
        serynges.SetActive(false);
        victoryScreen.SetActive(true);
        yield return new WaitForSeconds(5);
    }
}
