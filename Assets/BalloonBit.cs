using UnityEngine;
using System.Collections;

public class BalloonBit : MonoBehaviour {

	Animator anim;
	public GameObject ParentB;

	// Use this for initialization
	void Start () {
		anim = ParentB.GetComponent<Animator> ();
	}

	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") {
			anim.SetBool("IsPop", true);
		} 
	}

	// Update is called once per frame
	void Update () {
	
	}
}
