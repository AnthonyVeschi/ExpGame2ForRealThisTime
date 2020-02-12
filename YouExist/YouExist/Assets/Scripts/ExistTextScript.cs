using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExistTextScript : MonoBehaviour
{
    public GameObject staticVideo;

    void Start()
    {
        StartCoroutine("Survive");
    }

    IEnumerator Survive()
    {
        yield return new WaitForSeconds(4);
        gameObject.GetComponent<Text>().text = "SURVIVE";

        yield return new WaitForSeconds(1);
        staticVideo.SetActive(true);

        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("SurviveScene1");
    }
}
