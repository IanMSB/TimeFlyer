using UnityEngine;
using System.Collections;

public class SpikeSection : MonoBehaviour {
	
	public GameObject Spikes;

	
	public GameObject Spawn1;
	public GameObject Spawn2;
	public GameObject Spawn3;
	public GameObject Spawn4;
	public GameObject Spawn5;

	public int NumberOfSpikes;
	public float SpikeSpawnRate;
	
	public int NewNumber;
	
	public bool ReadyNow = true; 
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		NumberOfSpikes = NewNumber;
		if(NumberOfSpikes > 0)
		{
			int random = Random.Range(0, 5);
			if (random == 1 && ReadyNow == true)
			{
				Instantiate(Spikes, Spawn1.transform.position, Spawn1.transform.rotation);
				ReadyNow = false;
				StartCoroutine(Rate());
				
			}
			
			if (random == 2 && ReadyNow == true)
			{
				Instantiate(Spikes, Spawn2.transform.position, Spawn2.transform.rotation);
				ReadyNow = false;
				StartCoroutine(Rate());
			}
			
			if (random == 3 && ReadyNow == true)
			{
				Instantiate(Spikes, Spawn3.transform.position, Spawn3.transform.rotation);
				ReadyNow = false;
				StartCoroutine(Rate());
			}

			if (random == 4 && ReadyNow == true)
			{
				Instantiate(Spikes, Spawn4.transform.position, Spawn4.transform.rotation);
				ReadyNow = false;
				StartCoroutine(Rate());
			}

			if (random == 5 && ReadyNow == true)
			{
				Instantiate(Spikes, Spawn5.transform.position, Spawn5.transform.rotation);
				ReadyNow = false;
				StartCoroutine(Rate());
			}

		}
	}
	
	public void SetNumberOfSpikes()
	{
		NumberOfSpikes= NewNumber;
	}
	
	IEnumerator Rate() 
	{
		yield return new WaitForSeconds(SpikeSpawnRate);
		ReadyNow = true;
		NumberOfSpikes--;
		NewNumber--;
	}
}
