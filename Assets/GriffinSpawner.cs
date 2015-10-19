using UnityEngine;
using System.Collections;

public class GriffinSpawner : MonoBehaviour {
	float SpawnAgain;
	// Use this for initialization
	void Start () {
		SpawnAgain = 1;
	}

	//4 to -1.5

	// Update is called once per frame
	void FixedUpdate () {
		SpawnAgain -= (Menu.GameSpeed / 5);
		if (SpawnAgain <= 0)
		{
			Instantiate (Resources.Load ("Griffin"), new Vector3(transform.position.x,Random.Range (-1.5f, 4.0f),transform.position.z), transform.rotation); 
				SpawnAgain = 25;
			
		}
	}
}
