using UnityEngine;
using System.Collections;

public class FastWallSpeed : MonoBehaviour 
{
	
	
	
	public float forwardSpeed; //How fast the Wall moves.
	public bool forward = false; //Ensures that Wall will move at the start.
	public float destroyTime; //How Long the Wall will stay.
	public float Wait;
	
	

	void Start()
	{
		forward = false;
	}

	void Update() 
	{
		MoveForward(); //Ensures that Wall will move at the start.
		StartCoroutine(Delay());
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
	
	IEnumerator Delay() 
	{
		yield return new WaitForSeconds(Wait);
		forward = true;


	}
	
}