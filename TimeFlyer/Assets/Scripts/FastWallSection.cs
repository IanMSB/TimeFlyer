using UnityEngine;
using System.Collections;

public class FastWallSection : MonoBehaviour {
	
	public GameObject SafeZone1;
	public GameObject SafeZone2;
	public GameObject SafeZone3;
	public GameObject SafeZone4;
	public GameObject SafeZone5;

	public GameObject FastWall;

	
	public GameObject Spawn1;
	public GameObject Spawn2;
	public GameObject Spawn3;
	public GameObject Spawn4;
	public GameObject Spawn5;
	
	public int NumberOfFSafeZones;
	public float SafeZoneSpawnRate;
	
	public int NewNumber;
	
	public bool ReadyNow = true; 
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		NumberOfFSafeZones = NewNumber;
		if(NumberOfFSafeZones > 0)
		{
			int random = Random.Range(0, 5);
			if (random == 1 && ReadyNow == true)
			{
				Instantiate(SafeZone1, Spawn1.transform.position, Spawn1.transform.rotation);
				Instantiate(FastWall, Spawn1.transform.position, Spawn1.transform.rotation);
				ReadyNow = false;
				StartCoroutine(Rate());
				
			}
			
			if (random == 2 && ReadyNow == true)
			{
				Instantiate(SafeZone2, Spawn2.transform.position, Spawn2.transform.rotation);
				Instantiate(FastWall, Spawn2.transform.position, Spawn2.transform.rotation);
				ReadyNow = false;
				StartCoroutine(Rate());
			}
			
			if (random == 3 && ReadyNow == true)
			{
				Instantiate(SafeZone4, Spawn3.transform.position, Spawn3.transform.rotation);
				Instantiate(FastWall, Spawn3.transform.position, Spawn3.transform.rotation);
				ReadyNow = false;
				StartCoroutine(Rate());
			}
			
			if (random == 4 && ReadyNow == true)
			{
				Instantiate(SafeZone4, Spawn4.transform.position, Spawn4.transform.rotation);
				Instantiate(FastWall, Spawn4.transform.position, Spawn4.transform.rotation);
				ReadyNow = false;
				StartCoroutine(Rate());
			}
			
			if (random == 5 && ReadyNow == true)
			{
				Instantiate(SafeZone5, Spawn5.transform.position, Spawn5.transform.rotation);
				Instantiate(FastWall, Spawn5.transform.position, Spawn5.transform.rotation);
				ReadyNow = false;
				StartCoroutine(Rate());
			}
			
		}
	}
	
	public void SetNumberOfFastWalls()
	{
		NumberOfFSafeZones= NewNumber;
	}
	
	IEnumerator Rate() 
	{
		yield return new WaitForSeconds(SafeZoneSpawnRate);
		ReadyNow = true;
		NumberOfFSafeZones--;
		NewNumber--;
	}
}
