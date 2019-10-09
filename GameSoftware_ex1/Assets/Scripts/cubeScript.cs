using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

	GameObject player;

	// Use this for initialization
	void Start () {
		Debug.Log("Hello, cube");
		this.player = GameObject.Find("Capsule");
		Debug.Log("Find Player");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0,0, -2f * Time.deltaTime);
		if(transform.position.z < -50.0f) {
			Destroy(this);
			Debug.Log("Destroy player");
		}

		Vector3 p1 = transform.position;
		Debug.Log("Cube Position: " + p1);
		Vector3 p2 = this.player.transform.position;
		Debug.Log("Player Position: " + p2);
		Vector3 dir = p1 - p2;
		Debug.Log("Dir: " + dir);

		float dist = Vector3.Magnitude(dir);
		float radius1 = 0.2f;
		float radius2 = 0.2f;
		Debug.Log("Distance: " + dist);

		if(dist < radius1 + radius2) {
			Destroy(this);
		}
	}

	public void bigSize(GameObject gObject) {
		gObject.transform.localScale = new Vector3(3.0f, 3.0f, 3.0f);
	}

	void onTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Bike") {
			Debug.Log("Tag-Bike");
		} else {
			Debug.Log("Tag-None");
		}

		Destroy(other.gameObject);
	}
}
