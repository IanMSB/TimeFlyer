using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		StartCoroutine(LoadLevel());

	}


	IEnumerator LoadLevel() 
	{
		yield return new WaitForSeconds(5);
		
		Application.LoadLevel (1);
		
	}
}
