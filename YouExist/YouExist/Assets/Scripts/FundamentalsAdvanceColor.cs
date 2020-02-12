using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FundamentalsAdvanceColor : MonoBehaviour
{
    private Text t;
    private Color32 red;
    private Color32 green;
    public int[] colors;

    private int i;

    private void Start()
    {
        t = gameObject.GetComponent<Text>();

        red = new Color32(255, 94, 94, 255);
        green = new Color32(94, 255, 94, 255);

        i = 0;
        if (colors[i] == 0) { t.color = red; }
        else { t.color = green; }
    }

    public void AdvanceColor()
    {
        i++;
        if (colors[i] == 0) { t.color = red; }
        else { t.color = green; }
        //Debug.Log("traps are gay");
    }

}
