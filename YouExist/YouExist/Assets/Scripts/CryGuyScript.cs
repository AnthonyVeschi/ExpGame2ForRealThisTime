using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CryGuyScript : MonoBehaviour
{
    bool CanPush = false;

    public GameObject canvas;

    void Start()
    {
        StartCoroutine("Cry");
    }

    IEnumerator Cry()
    {
        yield return new WaitForSeconds(3);
        gameObject.GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(1);
        CanPush = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && CanPush)
        {

            gameObject.GetComponent<Animator>().SetTrigger("Push");
            StartCoroutine("ChangeScene");
        }
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(1);
        canvas.SetActive(true);

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("CoffeeScene");
    }
}
