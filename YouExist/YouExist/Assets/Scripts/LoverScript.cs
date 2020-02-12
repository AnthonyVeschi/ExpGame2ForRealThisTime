using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoverScript : MonoBehaviour
{
    public GameObject canvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerMovement>().stopMoving();
            StartCoroutine("ChangeScene");
        }
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(7);
        canvas.SetActive(true);
        gameObject.GetComponent<AudioSource>().Stop();

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("GoogleScene");
    }
}
