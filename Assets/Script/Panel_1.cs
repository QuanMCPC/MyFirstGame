using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_1 : MonoBehaviour
{
    public GameObject panel;
    void OnMouseDown()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
