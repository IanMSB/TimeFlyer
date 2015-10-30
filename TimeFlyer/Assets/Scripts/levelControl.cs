using UnityEngine;
using System.Collections;

public class levelControl : MonoBehaviour 
{
	
	
	public float[] waveTimes;
	
	public int currentWave = 0;
	public bool stopSpawning = false;
	public float myTimer = 0.0f;
	public float GroupNumber = 1f;
	public float i;

	public GameObject DeathGuy;
	public GameObject DeathSpawn;

	public AudioClip deathsound;
	public AudioClip hitsound;
	// Use this for initialization
	void Start () 
	{
	
		if ( waveTimes.Length <= 1 )
		{
			waveTimes = new float[ 15 ]; 
			waveTimes[ 0 ] = 01.0f; 
			waveTimes[ 1 ] = 20.0f; 
			waveTimes[ 2 ] = 35.0f;
			waveTimes[ 3 ] = 47.0f;
			waveTimes[ 4 ] = 70.0f;
			waveTimes[ 5 ] = 80.0f;
			waveTimes[ 6 ] = 92.0f;
			waveTimes[ 7 ] = 102.0f;
			waveTimes[ 8 ] = 118.0f;
			waveTimes[ 9 ] = 130.0f;
			waveTimes[ 10 ] = 144.0f;
			waveTimes[ 11 ] = 165.0f;
			waveTimes[ 12 ] = 177.0f;
			waveTimes[ 13 ] = 190.0f;
			waveTimes[ 14 ] = 215.0f;
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



	public void HitSound()
	{

//		audio.clip = hitsound;
//		audio.Play();

	}


	public void Reset()
	{
		Instantiate(DeathGuy, DeathSpawn.transform.position, DeathSpawn.transform.rotation);
//		audio.clip = deathsound;
//		audio.Play();
		StartCoroutine (ResetNow ());
	}
	
	
	
	void GroupNumber0()
	{
		GameObject.Find ("WallSpawnPoint").GetComponent<WallSection>().NewNumber = 5;
		GameObject.Find ("WallSpawnPoint").GetComponent<WallSection>().WallSpawnRate = 5;
	}

	void GroupNumber1()
	{
		
		GameObject.Find ("WallSpawnPoint").GetComponent<WallSection>().NewNumber = 13;
		GameObject.Find ("WallSpawnPoint").GetComponent<WallSection>().WallSpawnRate = 1;
		
	}

	void GroupNumber2()
	{
		
		GameObject.Find ("SpikeSpawnPoints").GetComponent<SpikeSection>().NewNumber = 10;
		GameObject.Find ("SpikeSpawnPoints").GetComponent<SpikeSection>().SpikeSpawnRate = 1;
		
	}

	void GroupNumber3()
	{
		
		GameObject.Find ("WallSpawnPoint").GetComponent<WallSection>().NewNumber = 22;
		GameObject.Find ("WallSpawnPoint").GetComponent<WallSection>().WallSpawnRate = 0.7f;
		
	}

	void GroupNumber4()
	{
		
		GameObject.Find ("SpikeSpawnPoints").GetComponent<SpikeSection>().NewNumber = 18;
		GameObject.Find ("SpikeSpawnPoints").GetComponent<SpikeSection>().SpikeSpawnRate = 0.5f;
		
	}

	void GroupNumber5()
	{
		
		GameObject.Find ("WallSpawnPoint").GetComponent<WallSection>().NewNumber = 5;
		GameObject.Find ("WallSpawnPoint").GetComponent<WallSection>().WallSpawnRate = 2;
		
	}

	void GroupNumber6()
	{
		
		GameObject.Find ("FastWallSpawnPoint").GetComponent<FastWallSection>().NewNumber = 3;
		GameObject.Find ("FastWallSpawnPoint").GetComponent<FastWallSection>().SafeZoneSpawnRate = 5;
		
	}

	void GroupNumber7()
	{
		
		GameObject.Find ("FastWallSpawnPoint").GetComponent<FastWallSection>().NewNumber = 6;
		GameObject.Find ("FastWallSpawnPoint").GetComponent<FastWallSection>().SafeZoneSpawnRate = 2.5f;
		
	}

	void GroupNumber8()
	{
		
		GameObject.Find ("FastWallSpawnPoint").GetComponent<FastWallSection>().NewNumber = 10;
		GameObject.Find ("FastWallSpawnPoint").GetComponent<FastWallSection>().SafeZoneSpawnRate = 1;
		
	}

	void GroupNumber9()
	{
		
		GameObject.Find ("MazeWallSpawnPoint1").GetComponent<MazeWallSection>().TurnOn();

		
	}

	void GroupNumber10()
	{
		
		GameObject.Find ("WallSpawnPoint").GetComponent<WallSection>().NewNumber = 22;
		GameObject.Find ("WallSpawnPoint").GetComponent<WallSection>().WallSpawnRate = 0.6f;
		
		
	}

	void GroupNumber11()
	{
		
		GameObject.Find ("SpikeSpawnPoints").GetComponent<SpikeSection>().NewNumber = 18;
		GameObject.Find ("SpikeSpawnPoints").GetComponent<SpikeSection>().SpikeSpawnRate = 0.5f;
		
	}

	void GroupNumber12()
	{
		
		GameObject.Find ("FastWallSpawnPoint").GetComponent<FastWallSection>().NewNumber = 6;
		GameObject.Find ("FastWallSpawnPoint").GetComponent<FastWallSection>().SafeZoneSpawnRate = 1.5f;

		
	}

	void GroupNumber13()
	{
		
		GameObject.Find ("WallSpawnPoint").GetComponent<WallSection>().NewNumber = 5;
		GameObject.Find ("WallSpawnPoint").GetComponent<WallSection>().WallSpawnRate = 5;
		
	}


	void GroupNumber14()
	{
		
		Application.LoadLevel (2);
		
	}


	IEnumerator ResetNow() 
	{
		yield return new WaitForSeconds(3);
		
		Application.LoadLevel (1);
		
	}
	
	
	
	
}
