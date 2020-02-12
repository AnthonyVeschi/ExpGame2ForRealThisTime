using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Survive1TextScript : MonoBehaviour
{
    public GameObject staticVideo;

    void Start()
    {
        StartCoroutine("ChangeScene");
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2);
        staticVideo.SetActive(true);

        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("CirclesUnite1");
    }
}
