using UnityEngine;
using System.Collections;


public class wallSpawn : MonoBehaviour {

	public bool Group1 = true; 
	public bool readynow = true; 		//Prevents the Wall Spawning all the time.
	public GameObject WallSpawnPoint; 	//Where the Wall will spawn from.
	public float WallDelay;				//How long before the next Wall piece is created.							
	public float NextSpeedUpAt;		//Speed up the spawn rate.
	public float MinSpawnSpeed;			//Min Wall Speed
	public float MaxSpawnSpeed;			//Max Wall Speed
	public float MinSpawnDelay;			//Min Wall Delay Spawn 
	public float MaxSpawnDelay;			//Min Wall Delay Spawn 
	public GameObject HighWall;
	public GameObject MidWall;
	public GameObject LowWall; 
	public float i;

	void Update () {

		NextSpeedUpAt = Mathf.Clamp(NextSpeedUpAt, MinSpawnSpeed, MaxSpawnSpeed);
		WallDelay = Mathf.Clamp (WallDelay, MinSpawnDelay, MaxSpawnDelay);

		if(readynow == true && Group1 == true)
		{	
			SpawnWall();
		}		
		
	}

	void SpawnWall()
	{
		
		for (i=0; i<10; i++)
		{
			
			
			int random = Random.Range(0, 3);
			if (random == 1 && readynow == true)
			{
				
				readynow = false;
				Instantiate(HighWall, WallSpawnPoint.transform.position, WallSpawnPoint.transform.rotation);
				StartCoroutine(Wait());
				StartCoroutine(SpeedUpTime());
				
				
			}
			if (random == 2 && readynow == true)
			{
				
				readynow = false;
				Instantiate(MidWall, WallSpawnPoint.transform.position, WallSpawnPoint.transform.rotation);
				StartCoroutine(Wait());
				StartCoroutine(SpeedUpTime());
				
			}
			if (random == 3 && readynow == true)
			{
				
				readynow = false;
				Instantiate(LowWall, WallSpawnPoint.transform.position, WallSpawnPoint.transform.rotation);
				StartCoroutine(Wait());
				StartCoroutine(SpeedUpTime());
				
			}
			
		}
		
	}
	

	
	
	IEnumerator Wait() 
	{
		yield return new WaitForSeconds(WallDelay);
		readynow = true;
	}

	IEnumerator SpeedUpTime() 
	{
		yield return new WaitForSeconds(NextSpeedUpAt);
		SpeedUp();
	}


	void SpeedUp()
		{
		WallDelay--;
		}




	
}