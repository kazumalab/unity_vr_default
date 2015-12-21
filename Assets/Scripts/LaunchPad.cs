using UnityEngine;
using System.Collections;

public class LaunchPad : MonoBehaviour {
	public GameObject dish_R;
	private float times;
	// Use this for initialization
	void Start () {
		times = 5;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Debug.Log ("time.time : " + Time.time);
		//秒ごとに処理させる
		if (times < Time.time) {
			CreateDish ();
			times += 5;
		}

	}

	void CreateDish(){
		Instantiate (dish_R, this.gameObject.transform.position, Quaternion.identity);
	}
}
