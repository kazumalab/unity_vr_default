using UnityEngine;
using System.Collections;

public class DishMove_C : MonoBehaviour {
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		int ran_y = Random.Range (5, 10);
		rb = GetComponent<Rigidbody> ();
		rb.AddForce (new Vector3(0f,ran_y,0f));
	}

	// Update is called once per frame
	void Update () {
	}
}
