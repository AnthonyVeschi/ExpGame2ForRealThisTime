using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanSupportLifeScript : MonoBehaviour
{
    Text t;

    private Color32 red;
    private Color32 green;
    private Color32 white;

    string emptyString;
    string waitString;
    string noLifeString;
    string yesLifeString;

    private void Start()
    {
        t = gameObject.GetComponent<Text>();

        white = new Color32(255, 255, 255, 255);
        red = new Color32(255, 200, 200, 255);
        green = new Color32(200, 255, 200, 255);

        emptyString = "";
        waitString = "please wait . . .";
        noLifeString = "this universe cannot support life";
        yesLifeString = "this universe can support life";

        t.text = emptyString;
    }

    public void PleaseWait()
    {
        t.text = waitString;
        t.color = white;
    }
    public void NoLife()
    {
        t.text = noLifeString;
        t.color = red;
    }
    public void YesLife()
    {
        t.text = yesLifeString;
        t.color = green;
    }
}
