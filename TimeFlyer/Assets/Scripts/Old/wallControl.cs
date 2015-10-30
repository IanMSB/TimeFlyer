using UnityEngine;
using System.Collections;

public class wallControl : MonoBehaviour 
{


	public float[] waveTimes;
	
	public int currentWave = 0;
	public bool stopSpawning = false;
	public bool readynow;
	public float myTimer = 0.0f;
	public float GroupNumber = 1f;
	public float i = 1f;
	public GameObject HighWall;
	public GameObject MidWall;
	public GameObject LowWall; 
	public GameObject WallSpawnPoint; 
	public float WallDelay;	
	
	


	// Use this for initialization
	void Start () 
	{

		if ( waveTimes.Length <= 1 )
		{
		waveTimes = new float[ 4 ]; 
		waveTimes[ 0 ] = 5.0f; 
		waveTimes[ 1 ] = 10.0f; 
		waveTimes[ 2 ] = 15.0f;
		waveTimes[ 3 ] = 20.0f;
		}
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		myTimer += Time.deltaTime; 

		if ( !stopSpawning )
		{
			if ( myTimer >= waveTimes[ currentWave ] ) 
			{
				Debug.Log("WAVE " + (currentWave + 1) + " HAS STARTED" ); 
				SendMessage("GroupNumber" + i);
				
				currentWave ++;
				i ++;
				
				
				if ( currentWave >= waveTimes.Length )
				{
					stopSpawning = true; 
				}
			}
		}
	}


	void GroupNumber1()
	{
		
		for (i=0; i<10; i++)
		{
			
			
			var random = Random.Range(0, 3);
			if (random == 1)
			{
				readynow = false;
				Instantiate(HighWall, WallSpawnPoint.transform.position, WallSpawnPoint.transform.rotation);
				Debug.Log ("HighWall");
				StartCoroutine(Wait());

				
			}
			if (random == 2)
			{
				readynow = false;
				Instantiate(MidWall, WallSpawnPoint.transform.position, WallSpawnPoint.transform.rotation);
				Debug.Log ("MidWall");
				StartCoroutine(Wait());
				
			}
			if (random == 3)
			{
				readynow = false;
				Instantiate(LowWall, WallSpawnPoint.transform.position, WallSpawnPoint.transform.rotation);
				Debug.Log ("LowWall");
				StartCoroutine(Wait());

			}
			
		}
		
	}

	IEnumerator Wait() 
	{
		yield return new WaitForSeconds(WallDelay);
		readynow = true;
	}
}
