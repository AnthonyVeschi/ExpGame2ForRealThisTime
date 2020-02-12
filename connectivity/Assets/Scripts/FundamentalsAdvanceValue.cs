using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FundamentalsAdvanceValue : MonoBehaviour
{
    private Text t;
    public string[] values;

    private int i;

    private void Start()
    {
        t = gameObject.GetComponent<Text>();

        i = 0;
        t.text = values[i];
    }

    public void AdvanceValue()
    {
        i++;
        t.text = values[i];
    }

}
