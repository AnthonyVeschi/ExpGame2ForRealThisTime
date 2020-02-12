using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Surive3TextScript : MonoBehaviour
{
    public GameObject[] circles;

    public GameObject staticVideo;

    void Start()
    {
        StartCoroutine("SpawnCircles");
    }

    IEnumerator SpawnCircles()
    {
        int i = 0;
        while (i < 20)
        {
            circles[i].SetActive(true);
            if (i < 10) { yield return new WaitForSeconds(0.5f); }
            else { yield return new WaitForSeconds(0.25f); }
            staticVideo.SetActive(true);
            if (i < 10) { yield return new WaitForSeconds(0.33f); }
            else { yield return new WaitForSeconds(0.15f); }
            staticVideo.SetActive(false);
            i++;
        }

        staticVideo.SetActive(true);
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene("CrowdScene");
    }
}
