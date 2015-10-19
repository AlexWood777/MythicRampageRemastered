using UnityEngine;
using System.Collections;

public class Endless : MonoBehaviour {

	public float Length;
	public float speed = 1;
	public float speedMultiplier;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate(-Vector3.right * Time.deltaTime * ((Menu.GameSpeed) * speedMultiplier));
	if (transform.position.x <= -Length) {

			transform.position = new Vector3 (Length -(-Length - transform.position.x),transform.position.y,transform.position.z);
				}
	}
}
