using UnityEngine;
using System.Collections;

public class BuildSpeed : MonoBehaviour {

	public float forwardSpeed;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(-forwardSpeed * Time.deltaTime, 0, 0); 
	}
}
