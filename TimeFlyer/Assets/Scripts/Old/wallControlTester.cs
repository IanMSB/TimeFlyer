using UnityEngine;
using System.Collections;
[RequireComponent(typeof(wallSpawn))]
public class wallControlTester : MonoBehaviour 
{


	public float[] waveTimes;
	
	public int currentWave = 0;
	public bool stopSpawning = false;
	public bool readynow = true;
	public float myTimer = 0.0f;
	public float GroupNumber = 1f;
	public float i;

	

	// Use this for initialization
	void Start () 
	{

		readynow = true;
		if ( waveTimes.Length <= 1 )
		{
		waveTimes = new float[ 4 ]; 
		waveTimes[ 0 ] = 01.0f; 
		waveTimes[ 1 ] = 20.0f; 
		waveTimes[ 2 ] = 40.0f;
		waveTimes[ 3 ] = 100.0f;
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
				i++;
				
				
				if ( currentWave >= waveTimes.Length )
				{
					stopSpawning = true; 
				}
			}
		}

	
	}




	void GroupNumber1()
	{
		
		Debug.Log("1" ); 
		
	}

	void GroupNumber2()
	{
		
		Debug.Log("2" ); 
		
	}



	
}
