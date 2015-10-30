using UnityEngine;
using System.Collections;

public class WallSection : MonoBehaviour {

	public GameObject HighWall;
	public GameObject MidWall;
	public GameObject LowWall;

	public GameObject WallSpawnPoint;

	public int NumberOfWalls;
	public float WallSpawnRate;

	public int NewNumber;

	public bool ReadyNow = true; 
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () 
	{
		NumberOfWalls = NewNumber;
		if(NumberOfWalls > 0)
		{
			int random = Random.Range(0, 6);
			if (random == 1 && ReadyNow == true)
			{
			Instantiate(HighWall, WallSpawnPoint.transform.position, WallSpawnPoint.transform.rotation);
			ReadyNow = false;
			StartCoroutine(Rate());
			
			}
				
			if (random == 2 && ReadyNow == true)
			{
			Instantiate(MidWall, WallSpawnPoint.transform.position, WallSpawnPoint.transform.rotation);
			ReadyNow = false;
			StartCoroutine(Rate());
			}
				
			if (random == 3 && ReadyNow == true)
			{
			Instantiate(LowWall, WallSpawnPoint.transform.position, WallSpawnPoint.transform.rotation);
			ReadyNow = false;
			StartCoroutine(Rate());
			}

			if (random == 4 && ReadyNow == true)
			{
				Instantiate(HighWall, WallSpawnPoint.transform.position, WallSpawnPoint.transform.rotation);
				ReadyNow = false;
				StartCoroutine(Rate());
				
			}
			
			if (random == 5 && ReadyNow == true)
			{
				Instantiate(MidWall, WallSpawnPoint.transform.position, WallSpawnPoint.transform.rotation);
				ReadyNow = false;
				StartCoroutine(Rate());
			}
			
			if (random == 6 && ReadyNow == true)
			{
				Instantiate(LowWall, WallSpawnPoint.transform.position, WallSpawnPoint.transform.rotation);
				ReadyNow = false;
				StartCoroutine(Rate());
			}
		}
	}

	public void SetNumberOfWalls()
	{
		NumberOfWalls = NewNumber;
	}

	IEnumerator Rate() 
	{
		yield return new WaitForSeconds(WallSpawnRate);
		ReadyNow = true;
		NumberOfWalls--;
		NewNumber--;
	}
}
