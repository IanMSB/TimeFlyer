using UnityEngine;
using System.Collections;

public class WallSpeed : MonoBehaviour 
{
	
	
	
	public float forwardSpeed; //How fast the Wall moves.
	public bool forward = true; //Ensures that Wall will move at the start.
	public float destroyTime; //How Long the Wall will stay.

	
	
	
	void Update() 
	{
		MoveForward(); //Ensures that Wall will move at the start.

		Destroy (gameObject, destroyTime); //Kills Wall
	}
	
	


	public void SetSpeed()
	{
		Debug.Log("SpeedSet");

	}






	void MoveForward()
	{
		if(forward == true) 
		{
			transform.Translate(-forwardSpeed * Time.deltaTime, 0, 0); 
		}
	}


	
}