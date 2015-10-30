using UnityEngine;
using System.Collections;

public class WinScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine(LoadMenu());
	}

	IEnumerator LoadMenu() 
	{
		yield return new WaitForSeconds(15);
		
		Application.LoadLevel (0);
		
	}


}


