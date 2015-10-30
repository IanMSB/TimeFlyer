using UnityEngine;
using System.Collections;

public class SafeZone : MonoBehaviour {

	public float GrowRate;
	public float GrowTime;
	public bool GrowNow;
	public bool ShrinkNow;
	public GameObject FastWall;
	public GameObject FastWallSpawnPoint;

	void Start () {
	
		GrowRate = GrowRate * Time.deltaTime;
		GrowNow = true;
	}
	
	// Update is called once per frame
	void Update () 
	
	{

		Grow();

	}

	void Grow()
	{
		if (GrowNow == true) 
		{
		transform.localScale += new Vector3 (0f, GrowRate, 0f);
		StartCoroutine(GrowFor());
		
		}
	}

	void Shrink()
	{
		if (ShrinkNow == true)
		{
		transform.localScale += new Vector3(0f, -GrowRate, 0f);
		StartCoroutine(ShrinkFor());
		
		}
	}


	IEnumerator GrowFor() 
	{
		yield return new WaitForSeconds(GrowTime);
		GrowNow = false;
		ShrinkNow = true;
		Shrink();

	}

	IEnumerator ShrinkFor() 
	{
		yield return new WaitForSeconds(GrowTime);
		Destroy(this.gameObject);

	}
}
