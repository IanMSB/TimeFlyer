using UnityEngine;
using System.Collections;

public class MazeWallSection : MonoBehaviour {
	

	
	
	public GameObject MazeWall1;
	public GameObject MazeWall2;
	public GameObject MazeWall3;
	public GameObject MazeWall4;
	public GameObject MazeWall5;
	public GameObject MazeWall6;
	public GameObject MazeWall7;
	public GameObject MazeWall8;
	public GameObject MazeWall9;


	public GameObject SpawnAbove;
	public GameObject SpawnRight;

	public float[] WallTimes;
	public float myTimer = 0.0f;
	public float WallNumber = 1f;
	public float i;
	public int currentWave = 0;

	public bool stopSpawning = false;
	
	public bool ReadyNow = false; 

	void Start () {
		
		
		if ( WallTimes.Length <= 1 )
		{
			WallTimes = new float[ 9 ]; 
			WallTimes[ 0 ] = 01.0f; 
			WallTimes[ 1 ] = 01.5f; 
			WallTimes[ 2 ] = 03.0f;
			WallTimes[ 3 ] = 03.2f;
			WallTimes[ 4 ] = 04.0f;
			WallTimes[ 5 ] = 05.0f;
			WallTimes[ 6 ] = 06.0f;
			WallTimes[ 7 ] = 07.0f;
			WallTimes[ 8 ] = 07.3f;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(ReadyNow == true)
		{
			myTimer += Time.deltaTime; 
		
			if ( !stopSpawning )
			{
				if ( myTimer >= WallTimes[ currentWave ] ) 
				{

					SendMessage("WallNumber0" + i);
					currentWave ++;
					i++;
				
					if ( currentWave >= WallTimes.Length )
					{
					stopSpawning = true; 
					}
				}
			}
		}
	}

	public void TurnOn()
	{
		ReadyNow = true;
	}
	
	
	void WallNumber00()
	{
		Instantiate(MazeWall1, SpawnRight.transform.position, SpawnRight.transform.rotation);
	}
	
	void WallNumber01()
	{
		Instantiate(MazeWall2, SpawnAbove.transform.position, SpawnAbove.transform.rotation);
		
	}
	
	void WallNumber02()
	{
 
		Instantiate(MazeWall3, SpawnAbove.transform.position, SpawnAbove.transform.rotation);
		
	}

	void WallNumber03()
	{
		
		Instantiate(MazeWall4, SpawnRight.transform.position, SpawnRight.transform.rotation);
		
	}

	void WallNumber04()
	{
		
		Instantiate(MazeWall5, SpawnRight.transform.position, SpawnRight.transform.rotation);
		
	}

	void WallNumber05()
	{
		
		Instantiate(MazeWall6, SpawnAbove.transform.position, SpawnAbove.transform.rotation);
		
	}

	void WallNumber06()
	{
		
		Instantiate(MazeWall7, SpawnAbove.transform.position, SpawnAbove.transform.rotation);
		
	}

	void WallNumber07()
	{
		
		Instantiate(MazeWall8, SpawnAbove.transform.position, SpawnAbove.transform.rotation);
		
	}

	void WallNumber08()
	{
		
		Instantiate(MazeWall9, SpawnRight.transform.position, SpawnRight.transform.rotation);
		
	}
	
}
