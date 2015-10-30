using UnityEngine;
using System.Collections;

public class CoinCollect : MonoBehaviour {
	void OnTriggerEnter(Collider col) 
	{
		if(col.gameObject.tag == "Player")
		{
			GameObject.Find ("Player").GetComponent<playerHP>().Health +=1;
			Destroy(this.gameObject);
		}
	}
}