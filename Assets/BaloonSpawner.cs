using UnityEngine;
using System.Collections;

public class BaloonSpawner : MonoBehaviour {
	float SpawnAgain;
	// Use this for initialization
	void Start () {
		SpawnAgain = 1;
	}
	
	//4 to -1.5
	
	// Update is called once per frame
	void FixedUpdate () {
		SpawnAgain -= 0.1f;
		if (SpawnAgain <= 0)
		{
			Instantiate (Resources.Load ("Balloon"), new Vector3(transform.position.x,Random.Range (-1.5f, 4.0f),transform.position.z), transform.rotation); 
			if (Menu.GameSpeed < 18)
			{
				SpawnAgain = 30 - (Menu.GameSpeed * 4);
			}
			else
			{
				SpawnAgain = 4;
			}
		}
	}
}
