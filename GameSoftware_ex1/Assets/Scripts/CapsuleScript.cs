using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScript : MonoBehaviour {

	// Use this for initialization
	
	void Start () {
		Debug.Log("Hello, Capsule");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A)) {
			float rndPos = Random.Range(0.0f, 0.5f);
			this.transform.position = new Vector3(0.0f, 0.0f, rndPos);
		}

		if(Input.GetKeyDown(KeyCode.B)) {
			float rndRot = Random.Range(0.0f, 360.0f);
			this.transform.rotation = Quaternion.Euler(rndRot, 0.0f, 0.0f);
		}

		if(Input.GetKey(KeyCode.UpArrow)) {
			this.transform.Translate(new Vector3(0.0f, 0.0f, 5.0f * Time.deltaTime));
		}

		if(Input.GetKey(KeyCode.DownArrow)) {
			this.transform.Translate(new Vector3(0.0f, 0.0f, -5.0f * Time.deltaTime));
		}

		if(Input.GetKey(KeyCode.LeftArrow)) {
			this.transform.Translate(new Vector3(0, 0, Time.deltaTime));
		}

		if(Input.GetKey(KeyCode.RightArrow)) {
			this.transform.Translate(0, Time.deltaTime, 0, Space.World);
		}

		if(Input.GetKey(KeyCode.R)) {
			this.transform.Rotate(90.0f * Time.deltaTime, 0.0f, 0.0f);
		}

		if(Input.GetKey(KeyCode.L)) {
			this.transform.Rotate(-90.0f * Time.deltaTime, 0.0f, 0.0f);
		}

		if(Input.GetKey(KeyCode.G)) {
			GameObject goCube = GameObject.Find("Cube");
			GameObject goCapsule = GameObject.Find("Capsule");
			goCube.GetComponent<CubeScript>().bigSize(goCapsule);
		}

		if(Input.GetKey(KeyCode.P)) {
			GameObject goCube = GameObject.Find("Cube");
			GameObject goCapsule = GameObject.Find("Capsule");
			goCube.transform.parent = goCapsule.transform;
		}

		if(Input.GetKey(KeyCode.N)) {
			GameObject goCube = GameObject.Find("Cube");
			GameObject goCapsule = GameObject.Find("Capsule");
			goCube.transform.parent = null;
		}
	}
}
