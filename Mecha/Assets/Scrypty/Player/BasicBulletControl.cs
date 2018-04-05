using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBulletControl : MonoBehaviour {
    public float speed;
    public float deathtimer;
    public bool isActive;
    private Rigidbody rb;
    public TriggerController tr;
    public int bulletNumber;
    public int damage;
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        isActive = false;
	}
	void FixedUpdate ()
    {
        if(isActive)
        {
            rb.velocity = rb.transform.forward * speed;
        }
	}
    private void Update()
    {
        if (isActive)
        {
            deathtimer -= Time.deltaTime;
            if (deathtimer <= 0.0f)
            {
                rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
                isActive = false;
                tr.Recall(bulletNumber);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            HP h = other.GetComponent<HP>();
            if(h!=null)
            {
                h.Damage(damage);
                tr.Recall(bulletNumber);
            }
        }
    }
}
