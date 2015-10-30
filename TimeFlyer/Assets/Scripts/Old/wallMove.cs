using UnityEngine;
using System.Collections;

public class wallMove : MonoBehaviour 
{
	
	
	
	public float forwardSpeed = 0.1f; //How fast the Wall moves.
	public bool forward = true; //Ensures that Wall will move at the start.
	public float destroyTime = 5.0f; //How Long the Wall will stay.
	
	
	
	
	void Update() 
	{
		MoveForward(); //Ensures that Wall will move at the start.
		
		Destroy (gameObject, destroyTime); //Kills Wall
	}
	
	
	void MoveForward()
	{
		if(forward == true) 
		{
			transform.Translate(-forwardSpeed, 0, 0); 
		}
	}


}