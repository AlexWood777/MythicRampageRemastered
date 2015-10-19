using UnityEngine;
using System.Collections;

public class MoveTowards : MonoBehaviour {
	public float Speed;

	Resolution res;

	// Use this for initialization
	void Start () {
		res = Screen.currentResolution;
		if(res.refreshRate == 60)
			QualitySettings.vSyncCount = 1;
		if(res.refreshRate == 120)
			QualitySettings.vSyncCount = 2;
		print (QualitySettings.vSyncCount);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		GetComponent<Rigidbody2D>().AddForce (new Vector2 ((-Speed * (Menu.GameSpeed / 2) * Time.deltaTime), 0f));
		if (transform.position.x < -10) {
			Destroy(gameObject);
				}
	}
}
