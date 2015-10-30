using UnityEngine;
using System.Collections;

public class playerHP : MonoBehaviour {


	public  int Health = 5;
	public  static int HealthDisplay = 5;

	public float drainrate = 3.5f;
	public int drainamount;
	public bool Drain; 


	// Use this for initialization
	void Start () {

		//Health = energyCount;
		HealthDrain ();
		Drain = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		HealthDrain();
		HealthDisplay = Health;
		if (Health < 0) 
		{
			DeathAni();

		}

	}

	void HealthDrain()
	{
		if (Drain == true) 
		{
		Health = Health - drainamount;
		Drain = false;
		//Debug.Log ("HP less!");

		StartCoroutine (DrainRate ());
		}
	}

	void DeathAni()
	{
		GameObject.Find ("LevelControl").GetComponent<levelControl>().Reset();

		Destroy(this.gameObject);
	}

		

	IEnumerator DrainRate() 
	{
		yield return new WaitForSeconds(drainrate);
		Drain = true;

	}

	IEnumerator GameOver() 
	{
		yield return new WaitForSeconds(3);

		Application.LoadLevel (0);
		
	}


}
