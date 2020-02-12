using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DetermineButtonScript : MonoBehaviour
{

    public GameObject n;
    private Button b;
    private FundamentalsNumbersScript fns;

    public GameObject canSupportLife;

    public GameObject electron;
    private Animator anim;

    private bool canPress;

    int i;

    void Start()
    {
        fns = n.GetComponent<FundamentalsNumbersScript>();

        b = gameObject.GetComponent<Button>();
        b.onClick.AddListener(btnTask);

        anim = electron.GetComponent<Animator>();

        canPress = true;

        i = 0;
    }

    void btnTask()
    {
        if (!canPress) { return; }

        fns.AdvanceChildren();

        switch (i)
        {
            case (0):
                anim.SetTrigger("Crash");
                break;
            case (1):
                anim.SetTrigger("Crash");
                break;
            case (2):
                anim.SetTrigger("Float");
                break;
            case (3):
                anim.SetTrigger("Crash");
                break;
            case (4):
                anim.SetTrigger("Float");
                break;
            case (5):
                anim.SetTrigger("Float");
                break;
            case (6):
                anim.SetTrigger("Orbit");
                StartCoroutine("ChangeScene");
                break;
        }
        i++;
        StartCoroutine("Wait");
    }

    IEnumerator Wait()
    {
        canPress = false;
        canSupportLife.GetComponent<CanSupportLifeScript>().PleaseWait();

        yield return new WaitForSeconds(1f);
        anim.SetTrigger("ReturnToIdle");

        if (i == 7) { canSupportLife.GetComponent<CanSupportLifeScript>().YesLife(); }
        else { canSupportLife.GetComponent<CanSupportLifeScript>().NoLife(); }

        if (i < 7) { canPress = true; }
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("StaticFromUniverse");
    }
}
