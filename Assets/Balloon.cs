using UnityEngine;
using System.Collections;

public class Balloon : MonoBehaviour {

	public static bool IsEaten;
	public static bool IsPopped;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		IsEaten = false;
		IsPopped = false;
	}


	// Update is called once per frame
	void FixedUpdate () {
	
		IsEaten = anim.GetBool ("IsEat");
		IsPopped = anim.GetBool ("IsPop");
		//Debug.Log (IsEaten);
	
		if ((IsEaten == true) && (IsPopped == true))
		{
			GetComponent<Rigidbody2D>().AddForce (new Vector2 (0f, -100f));
		}
		else if (IsEaten == true)
		{
			GetComponent<Rigidbody2D>().AddForce (new Vector2 (0f, 200f));
		}
		else if (IsPopped == true)
		{
			GetComponent<Rigidbody2D>().AddForce (new Vector2 (0f, -100f));
		}

	}
}
