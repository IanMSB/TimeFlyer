using UnityEngine;
using System.Collections;

public class HitScript : MonoBehaviour {


	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col) 
	{
		if (col.gameObject.tag == "Player") 
		{
			Debug.Log ("Hit!");
			GameObject.Find ("Player").GetComponent<playerHP>().Health -=7;
			GameObject.Find ("LevelControl").GetComponent<levelControl>().HitSound();
			GameObject.Find ("HitSpawnPoint").GetComponent<HitAnimations>().Hit();
			Destroy(this.gameObject);

		}
		
	}
}
