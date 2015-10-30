using UnityEngine;
using System.Collections;

public class BuildingSpawn : MonoBehaviour {
	
	public GameObject Build1;
	public GameObject Build2;
	public GameObject Build3;
	public GameObject Build4;
	public GameObject Build5;
	public GameObject Build6;

	
	
	public GameObject Spawn;

	

	public float WaitTime;
	

	
	public bool ReadyNow = true; 
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () 
	{



			int random = Random.Range(0, 6);
			if (random == 1 && ReadyNow == true)
			{
				Instantiate(Build1, Spawn.transform.position, Spawn.transform.rotation);

				ReadyNow = false;
				StartCoroutine(Rate());
				
			}
			
			if (random == 2 && ReadyNow == true)
			{
				Instantiate(Build2, Spawn.transform.position, Spawn.transform.rotation);

				ReadyNow = false;
				StartCoroutine(Rate());
			}
			
			if (random == 3 && ReadyNow == true)
			{
				Instantiate(Build3, Spawn.transform.position, Spawn.transform.rotation);
				;
				ReadyNow = false;
				StartCoroutine(Rate());
			}
			
			if (random == 4 && ReadyNow == true)
			{
				Instantiate(Build4, Spawn.transform.position, Spawn.transform.rotation);

				ReadyNow = false;
				StartCoroutine(Rate());
			}
			
		if (random == 5 && ReadyNow == true)
		{
			Instantiate(Build4, Spawn.transform.position, Spawn.transform.rotation);
			
			ReadyNow = false;
			StartCoroutine(Rate());
		}

		if (random == 6 && ReadyNow == true)
		{
			Instantiate(Build4, Spawn.transform.position, Spawn.transform.rotation);
			
			ReadyNow = false;
			StartCoroutine(Rate());
		}
			

	}
	

	IEnumerator Rate() 
	{
		yield return new WaitForSeconds(WaitTime);
		ReadyNow = true;

	}
}
