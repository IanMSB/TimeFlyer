using UnityEngine;
using System.Collections;

public class HitAnimations : MonoBehaviour {

	public GameObject Spawn;
	public GameObject HitAni;
	// Use this for initialization
	public void Hit () {
		Instantiate(HitAni, Spawn.transform.position, Spawn.transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
