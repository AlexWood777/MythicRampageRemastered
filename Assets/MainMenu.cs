using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public GameObject StartB;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
		if (Input.GetMouseButtonDown (0)) {
						if (hit.collider == StartB.GetComponent<Collider2D>()) {
								Application.LoadLevel ("Game");
						}
				}
	}
}
