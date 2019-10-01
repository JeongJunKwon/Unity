using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour {

	// Use this for initialization
	private GameObject player;
	void Start () {
		this.player = GameObject.Find("Capsule");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0,0, -2f * Time.deltaTime);
		if(transform.position.z < -50.0f) {
			Destroy(this);
			Debug.Log("Destory player");
		}

		Vector3 p1 = transform.position;
		Debug.Log("Cube Position: " + p1);
		Vector3 p2 = this.player.transform.position;
		Debug.Log("Player Position: " + p2);
		Vector3 dir = p1 - p2;

		Debug.Log("Dir): " + dir);

		float dist = Vector3.Magnitude(dir);
		float radius1 = 0.2f;
		float radius2 = 0.2f;
		Debug.Log("Distance: " + dist);

		if(dist < radius1 + radius2) {
			Destroy(this);
		}
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Bike") {
			Debug.Log("Tag-Bike");
		}
	}
}
