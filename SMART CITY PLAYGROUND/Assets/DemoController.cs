using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoController : MonoBehaviour
{
    public GameObject seg1, seg2, seg3, seg4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            HideAll();
            seg1.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            HideAll();
            seg2.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            HideAll();
            seg3.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            HideAll();
            seg4.SetActive(true);
        }
    }

    void HideAll()
    {
        seg1.SetActive(false);
        seg2.SetActive(false);
        seg3.SetActive(false);
        seg4.SetActive(false);
    }
}
