using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

	[SerializeField] GameObject thingToSpawn;
	[SerializeField] float delayBetweenSpawns=25.0f;
	[SerializeField] float timeOfNextSpawn=1f;
	int amountToSpawn=5;
	static int amountSpawned=1;
	int currentHealth;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= timeOfNextSpawn&&amountSpawned<amountToSpawn)
		{
			Instantiate(thingToSpawn,transform.position,Quaternion.identity);
			timeOfNextSpawn = Time.time + delayBetweenSpawns;
			amountSpawned++;
		}
	}

	static public void EnemyDie()
		{
			amountSpawned--;
		}
}