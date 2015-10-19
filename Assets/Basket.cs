using UnityEngine;
using System.Collections;

public class Basket : MonoBehaviour {

	Animator anim;
	public GameObject ParentB;

	// Use this for initialization
	void Start () {
		anim = ParentB.GetComponent<Animator> ();
	}

	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") {
			anim.SetBool("IsEat", true);
		} 
	}

	// Update is called once per frame
	void Update () {
	
	}
}
