using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechaSpawner : MonoBehaviour {
    public GameObject[] bottoms;
    public GameObject[] cores;
    public GameObject[] lefts;
    public GameObject[] rights;
    public LegController bottom;
    public CoreController core;
    public ArmController left;
    public ArmController right;
    public void Start()
    {
        spawnBottom(0);
        spawnCore(0);
        spawnRight(0);
        spawnLeft(0);
    }
	public void spawnBottom(int bottomNumber)
    {
        bottom= (Instantiate(bottoms[bottomNumber]) as GameObject).GetComponent<LegController>();
        bottom.transform.parent = this.gameObject.transform;
        bottom.transform.localPosition = new Vector3(0.0f, bottom.height, 0.0f);
    }
    public void spawnCore(int coreNumber)
    {
        core= (Instantiate(cores[coreNumber]) as GameObject).GetComponent<CoreController>();
        core.transform.parent = this.gameObject.transform;
        core.transform.localPosition = new Vector3(0.0f, bottom.transform.localPosition.y+ core.height, 0.0f);
    }
    public void spawnRight(int rightNumber)
    {
        right= (Instantiate(rights[rightNumber]) as GameObject).GetComponent<ArmController>();
        right.transform.parent = this.gameObject.transform;
        right.transform.localPosition = new Vector3(right.width, bottom.transform.localPosition.y + core.righty+right.hight, 0.0f);
    }
    public void spawnLeft(int leftNumber)
    {
        left = (Instantiate(lefts[leftNumber]) as GameObject).GetComponent<ArmController>();
        left.transform.parent = this.gameObject.transform;
        left.transform.localPosition = new Vector3(left.width, bottom.transform.localPosition.y + core.lefty + left.hight, 0.0f);
    }
}
