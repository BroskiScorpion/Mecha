using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelownikControll : MonoBehaviour {

    public Camera c;
    public bool pad;
    public float oddalenie;
    private void Start()
    {
        c = FindObjectOfType<Camera>();
    }
    void Update()
    {

        if (pad == false)
        {
            Ray camray = c.ScreenPointToRay(Input.mousePosition);
            Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
            float rayLength;

            if (groundPlane.Raycast(camray, out rayLength))
            {
                Vector3 point = camray.GetPoint(rayLength);
                this.transform.position = new Vector3(point.x, 1.0f, point.z);
            }
        }
        else
        {
            Vector2 potat = new Vector2(Input.GetAxis("RJoyHorizontal"), Input.GetAxis("RJoyVertical"));
            if(potat.magnitude>0.0f)
            {
                potat = potat.normalized;
                this.transform.localPosition = new Vector3(potat.x * oddalenie, -1.0f, potat.y * oddalenie);
            }
        }
    }
}
