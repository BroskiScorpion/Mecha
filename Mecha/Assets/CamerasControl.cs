using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasControl : MonoBehaviour {

    public Camera[] cameras;
    public void Start()
    {
        setUp();
        Debug.Log("SetUp");
    }
    public void setUp()
    {
        if (cameras.Length == 1)
        {
            cameras[0].rect = new Rect(0.0f, 0.0f, 1.0f, 1.0f);
        }
        if (cameras.Length == 2)
        {
            cameras[0].rect = new Rect(0.0f, 0.5f, 1.0f, 0.5f);
            cameras[1].rect = new Rect(0.0f, 0.0f, 1.0f, 0.5f);
        }
        if (cameras.Length == 3)
        {
            cameras[0].rect = new Rect(0.0f, 0.5f, 0.5f, 0.5f);
            cameras[1].rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
            cameras[2].rect = new Rect(0.0f, 0.0f, 1.0f, 0.5f);
        }
        if (cameras.Length == 4)
        {
            Debug.Log("4");
            cameras[0].rect = new Rect(0.0f, 0.5f, 0.5f, 0.5f);
            cameras[1].rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
            cameras[2].rect = new Rect(0.0f, 0.0f, 0.5f, 0.5f);
            cameras[3].rect = new Rect(0.5f, 0.0f, 0.5f, 0.5f);
        }
    }
}
