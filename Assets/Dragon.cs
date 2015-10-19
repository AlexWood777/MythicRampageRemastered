using UnityEngine;
using System.Collections;

public class Dragon : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Threat") {
			Application.LoadLevel ("GameOver");
		} 
	}

	// Update is called once per frame
	void FixedUpdate () {
	
		if (Input.GetKey (KeyCode.DownArrow)) {
			GetComponent<Rigidbody2D>().AddForce (new Vector2 (0f, -10000f) * Time.fixedDeltaTime);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			GetComponent<Rigidbody2D>().AddForce (new Vector2 (0f, 10000f) * Time.fixedDeltaTime);
		}
	
	}
}
