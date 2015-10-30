using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {

	public float speed = 3.0f;
	private Vector3 targetPos;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float distance = transform.position.z - Camera.main.transform.position.z; 
		targetPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
		targetPos = Camera.main.ScreenToWorldPoint(targetPos);
		
		//transform.position = new Vector3(Mathf.Clamp(transform.position.x, -75, 75), Mathf.Clamp(transform.position.y, 25, 85), transform.position.z); //Keeps the player on screen.
		transform.position = Vector3.MoveTowards (transform.position, targetPos, speed * Time.deltaTime); //How fast the player can move.
	
	}
}
