using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryEndRunSequence : MonoBehaviour
{

    public GameObject player;
    public GameObject serynges;
    public GameObject victoryScreen;
    public GameObject FadeOut;

    void Start()
    {
        StartCoroutine(VictoryEndSequence());
    }

    IEnumerator VictoryEndSequence()
    {
        player.GetComponent<PlayerMove>().enabled = false;
        serynges.SetActive(false);
        victoryScreen.SetActive(true);
        yield return new WaitForSeconds(2);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
