using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FundamentalsNumbersScript : MonoBehaviour
{
    private FundamentalsAdvanceValue av;
    private FundamentalsAdvanceColor ac;

    public void AdvanceChildren()
    {
        foreach (Transform child in transform)
        {
            av = child.GetComponent<FundamentalsAdvanceValue>();
            ac = child.GetComponent<FundamentalsAdvanceColor>();
            av.AdvanceValue();
            ac.AdvanceColor();
        }
    }
}
