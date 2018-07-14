using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {
    public int playernumber;
    private Rigidbody rb;
    private Transform tr;
    public float speed;
    public TriggerController tr1;
    public TriggerController tr2;
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
    }
	
	
	void Update ()
    {
        float y = Input.GetAxis("Vertical" + playernumber);
        float x = Input.GetAxis("Horizontal" + playernumber);
        float yl;
        float xl;
        rb.velocity = new Vector3(x*speed, 0.0f, y * speed);
        if(Input.GetButton("Fire1"+playernumber))
        {
            if(tr1==null)
            {
                tr1=GetComponentInChildren<MechaSpawner>().left.GetComponentInChildren<TriggerController>();
            }
            else
            {
                tr1.Trigger();
            }
        }
        if(Input.GetButton("Fire2"+playernumber))
        {
            if (tr2 == null)
            {
                tr2 = GetComponentInChildren<MechaSpawner>().right.GetComponentInChildren<TriggerController>();
            }
            else
            {
                tr2.Trigger();
            }
        }
	}
}
