using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public static float GameSpeed;

	// Use this for initialization
	void Start () {
		GameSpeed = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		GameSpeed += 0.001f;
	}
}
