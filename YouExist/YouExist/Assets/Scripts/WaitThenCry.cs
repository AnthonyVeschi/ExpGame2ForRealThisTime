using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitThenCry : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("Cry");
    }

    IEnumerator Cry()
    {
        yield return new WaitForSeconds(0.15f);
        gameObject.GetComponent<AudioSource>().enabled = true;
    }
}
