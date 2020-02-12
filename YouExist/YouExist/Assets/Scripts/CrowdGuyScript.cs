using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdGuyScript : MonoBehaviour
{
    public int speed = 12;

    public int crySecs;

    private void Start()
    {
        //StartCoroutine("TooShyShyHushHushCryToCry");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            transform.position = Vector2.MoveTowards(transform.position, other.transform.position, -1 * speed * Time.deltaTime);
        }
    }

    IEnumerator TooShyShyHushHushCryToCry()
    {
        while (true)
        {
            yield return new WaitForSeconds(crySecs);
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
