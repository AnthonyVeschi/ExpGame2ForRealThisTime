using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public Button btn;

    void Start()
    {
        btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(ClickyClicky);
    }

    public void ClickyClicky()
    {
        SceneManager.LoadScene("CreateUniverseScene");
    }
}
