using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoogleCameraScript : MonoBehaviour
{
    public GameObject canvas;
    Camera cam;

    void Start()
    {
        cam = Camera.main;
        StartCoroutine("End");
    }

    IEnumerator End()
    {
        yield return new WaitForSeconds(3);
        canvas.SetActive(true);
        cam.fieldOfView = 160;
        yield return new WaitForSeconds(1);
        canvas.SetActive(false);

        yield return new WaitForSeconds(3);
        canvas.SetActive(true);
        cam.fieldOfView = 300;
        yield return new WaitForSeconds(1);
        canvas.SetActive(false);

        yield return new WaitForSeconds(3);
        canvas.SetActive(true);
        cam.fieldOfView = 9999;
        yield return new WaitForSeconds(1);

        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Menu");
    }
}
