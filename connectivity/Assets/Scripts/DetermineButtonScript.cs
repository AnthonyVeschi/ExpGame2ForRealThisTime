using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetermineButtonScript : MonoBehaviour
{

    public GameObject n;
    private Button b;
    private FundamentalsNumbersScript fns;

    void Start()
    {
        fns = n.GetComponent<FundamentalsNumbersScript>();

        b = gameObject.GetComponent<Button>();
        b.onClick.AddListener(btnTask);
    }

    void btnTask()
    {
        fns.AdvanceChildren();
    }
}
