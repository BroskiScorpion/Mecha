using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour {
    public int numberOfPlayers;
    public PlayerControler[] pc;
    private bool isSwitching;
	void Update()
    {
        if (numberOfPlayers == 1);
        {
            this.gameObject.transform.parent = pc[0].transform;
            this.gameObject.transform.localPosition -= this.gameObject.transform.localPosition * Time.deltaTime;
        }
    }
}
