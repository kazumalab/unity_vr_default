using UnityEngine;
using System.Collections;

public class DishMove_L : MonoBehaviour {
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		int ran_x = Random.Range (6, 14);
		int ran_y = Random.Range (5, 10);
		rb = GetComponent<Rigidbody> ();
		rb.AddForce (new Vector3(-ran_x,ran_y,0f)*Time.timeScale);
	}

	// Update is called once per frame
	void Update () {
	}
}