using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveGameControler : MonoBehaviour {

    public List<GameObject> active;
    public List<GameObject> prepared;
    public GameObject[] enemyPrefabs;
	public List<String> waveInfo;
	public List<String> packInfo;
    public int waveNumber;
    public int waveSize;
    public int[] wave;
    public Transform[] spawnPoints;
	void Start ()
    {
		prepWaveInfo();
        PrepareWave(0);
	}
	public prepAllWaveInfo()
	{
		String AllWaveInfo = File.ReadAllText("waveinfo.txt");
		String temp="";
		int i=0;
		while(i<AllWaveInfo.Length)
		{
			if(true)
			{
				i++;
			}
		}
	}
    public GameObject getNextEnemy()
    {
        if(enemyPrefabs.Length<1)
        {
            return null;
        }
        else
        {
            return enemyPrefabs[0];
        }
    }
	public void PrepareWave(int waveSize)
    {
        for(int i=0;i<waveSize;i++)
        {
            GameObject next = getNextEnemy();
            if(next!=null)
            {
                GameObject obj = Instantiate(next);
                prepared.Add(obj);
                obj.transform.parent = this.gameObject.transform;
                obj.transform.localPosition = new Vector3(0.0f, prepared.Count*(-2), 0.0f);
            }
        }
    }
    public void Spawn()
    {
        active.Add(prepared[0]);
        prepared.RemoveAt(0);
        active[active.Count - 1].transform.parent = getNextSpawnpoint();
        active[active.Count - 1].transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
    }
    public Transform getNextSpawnpoint()
    {
        return null;
    }
	public void SpawnPack(int rozmiar)
	{
		for(int i=0;i<rozmiar;i++)
		{
			Spawn();
		}
	}
}
