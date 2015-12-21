using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FPSCamera : MonoBehaviour {
	public Transform headChild;
	public GameObject ball;
	private bool shooting = false;
	private float bulletsPerSecond = 14.0f;
	public Text score;

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		InvokeRepeating("shot", 0.0f, 1.0f / bulletsPerSecond);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		score.text = "Score : " + BallMove.point;
		shooting = false;
		Vector2 mouseSpeed = new Vector2 (Input.GetAxis ("Mouse X"), Input.GetAxis ("Mouse Y"));
		//ここは頭の動きを見る、パソコン用
		transform.Rotate (0, mouseSpeed.x, 0);
		headChild.Rotate (-mouseSpeed.y, 0, 0);

		if (Input.GetButton("Jump")) {
			shooting = true;
		}
	}

	void shot(){
		if (!shooting)return;
		Instantiate(ball,new Vector3(transform.position.x,transform.position.y,transform.position.z),this.gameObject.transform.rotation);
	}
}
