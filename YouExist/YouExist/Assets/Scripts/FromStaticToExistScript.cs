using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FromStaticToExistScript : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("ChangeScene");
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2.3f);
        SceneManager.LoadScene("ExistScene");
    }
}
