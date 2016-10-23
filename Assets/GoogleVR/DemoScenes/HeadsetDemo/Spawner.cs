using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
    public GameObject[] prefabs;
    public float startWait = 1f;
    public float spawnWait = 2f;
    public float waveWait = 7f;
    public int monsterCount = 5;
    public bool active = true;
	// Use this for initialization
	void Start () {
        transform.position = Camera.main.transform.position;
        StartCoroutine(SpawnWaves());
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        int roundCount = 0;
        while (active)
        {
            if(roundCount > 5)
            {
                if(roundCount < 10)
                {
                    spawnWait = spawnWait - 0.15f;
                }
            }
            for(int i = 0; i < monsterCount; i++)
            {
                GameObject.Instantiate(prefabs[Random.Range(0, prefabs.Length)]);
                
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
            if(waveWait > 1)
            {
                waveWait--;
            }
            roundCount++;
        }
    }
}
