using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celowanie : MonoBehaviour {

    private Transform tr;
    public GameObject celownik;
    void Start()
    {
        tr = GetComponent<Transform>();
    }
	void Update ()
    {
        Vector3 cel = new Vector3(celownik.transform.position.x, tr.position.y, celownik.transform.position.z);
        tr.LookAt(cel);
	}
}
