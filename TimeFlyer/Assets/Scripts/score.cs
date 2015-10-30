using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class score : MonoBehaviour {
	public Text text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	GetComponent<GUIText>().text = playerHP.HealthDisplay.ToString();
	}
}
