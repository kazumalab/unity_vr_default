using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallMove : MonoBehaviour {
	private Rigidbody rb;

	public static int point = 0;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce (transform.forward * 1000f);
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "dishes") {
			point++;
			Destroy (other.gameObject);
		}
	}
}
