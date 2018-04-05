using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour {

    public GameObject bullet;
    public GameObject[] bullets;
    public Transform przechowalnia;
    private Transform tr;
    public float shottimer;
    public float pousetime;
    public float reloadingtime;
    public float reloadingpouse;
    public int bulletsleft;
    public int magazynek;

    public void Start()
    {
        bullets = new GameObject[magazynek];
        tr = GetComponent<Transform>();
        for(int i=0;i<magazynek;i++)
        {
            bullets[i] = Instantiate(bullet, przechowalnia);
            bullets[i].transform.localPosition = new Vector3(0.0f,-2.0f*i,0.0f);
            BasicBulletControl z = bullets[i].GetComponent<BasicBulletControl>();
            if(z!=null)
            {
                z.bulletNumber = i;
                z.tr = this;
            }
        }
    }
    public void Trigger()
    {
        if (shottimer<=0 && reloadingtime <=0)
        {
            shottimer = pousetime;
            bullets[magazynek - bulletsleft].transform.parent = null;
            bullets[magazynek - bulletsleft].transform.parent = this.transform;
            bullets[magazynek-bulletsleft].transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
            bullets[magazynek-bulletsleft].transform.localRotation = Quaternion.Euler(new Vector3(0.0f, 90.0f, 0.0f));
            bullets[magazynek-bulletsleft].transform.parent = null;
            BasicBulletControl z = bullets[magazynek - bulletsleft].GetComponent<BasicBulletControl>();
            if(z!=null)
            {
                z.deathtimer = 2.0f;
                z.isActive = true;
            }

            shottimer = pousetime;
            bulletsleft -= 1;
            if(bulletsleft<=0)
            {
                bulletsleft = magazynek;
                reloadingtime = reloadingpouse;
            }
        }
    }
    public void Update()
    {
        shottimer -= Time.deltaTime;
        reloadingtime -= Time.deltaTime;
    }
    public void Recall(int i)
    {
        bullets[i].transform.parent = przechowalnia;
        bullets[i].transform.localPosition = new Vector3(0.0f, -2.0f * i, 0.0f);
    }
}
