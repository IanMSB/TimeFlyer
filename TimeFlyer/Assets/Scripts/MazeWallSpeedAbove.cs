using UnityEngine;
using System.Collections;

public class MazeWallSpeedAbove : MonoBehaviour 
{
	
	
	
	public float forwardSpeed; //How fast the Spike moves.
	public bool forward = true; //Ensures that Spike will move at the start.
	public float destroyTime; //How Long the Spike will stay.
	
	
	
	
	void Update() 
	{
		MoveForward(); //Ensures that Spike will move at the start.
		
		Destroy (gameObject, destroyTime); //Kills Spike
	}
	
	
	
	
	
	
	
	
	
	void MoveForward()
	{
		if(forward == true) 
		{
			transform.Translate(0, -forwardSpeed * Time.deltaTime, 0); 
		}
	}
	
	
	
}