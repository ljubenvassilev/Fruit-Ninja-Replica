using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawnerScript : MonoBehaviour
{

	public GameObject fruitPrefab;
	public Transform[] spawnPoints;
	public float minDelay = .1f;
	public float maxDelay = 1f;

	// Use this for initialization
	void Start ()
	{
		StartCoroutine(SpawnFruits());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnFruits()
	{
		while (true)
		{
			float delay = Random.Range(minDelay, maxDelay);
			yield return new WaitForSeconds(delay);
			int spawnIndex = Random.Range(0, spawnPoints.Length);
			Transform spawnPoint = this.spawnPoints[spawnIndex];
			GameObject spawnedFruit = Instantiate(fruitPrefab, spawnPoint);
			Destroy(spawnedFruit, 5f);
		}
	}
}
