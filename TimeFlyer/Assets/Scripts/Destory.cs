using UnityEngine;
using System.Collections;

public class Destory : MonoBehaviour {

	public float InSec;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (this.gameObject, InSec); //Kills Wall
	}
}
