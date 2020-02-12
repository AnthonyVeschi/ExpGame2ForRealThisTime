using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoffeeGuyScript : MonoBehaviour
{
    bool cried = false;
    public int loud;

    public GameObject canvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (cried) { return; }
        if (collision.gameObject.tag == "Player")
        {
            if (loud == 1) { gameObject.GetComponent<AudioSource>().volume = 1; }
            gameObject.GetComponent<AudioSource>().Play();
            cried = true;
            if (loud == 1) { StartCoroutine("ChangeScene"); }
        }
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(1);
        canvas.SetActive(true);

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("SexScene");
    }
}
