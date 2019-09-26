using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A)) {
			float rnd = Random.Range(0.0f, 0.5f);
			this.transform.position = new Vector3(0.0f, 0.0f, rnd);
		}

		if(Input.GetKeyDown(KeyCode.B)) {
			float rnd = Random.Range(0.0f, 360.0f);
			this.transform.rotation = Quaternion.Euler(rnd, 0.0f, 0.0f);
		}

		if(Input.GetKeyDown(KeyCode.R)) {
			this.transform.Rotate(90.0f * Time.deltaTime, 0.0f, 0.0f);
		}

		if(Input.GetKeyDown(KeyCode.L)) {
			this.transform.Rotate(-90.0f * Time.deltaTime, 0.0f, 0.0f);
		}

		if(Input.GetKey(KeyCode.G)) {
			GameObject go = GameObject.Find("Cube") as GameObject;
			go.GetComponent<cubeScript>().bigsize();
		}

		if(Input.GetKey(KeyCode.H)) {
			GameObject go = GameObject.Find("Capsule") as GameObject;
			go.GetComponent<cubeScript>().bigsize();
		}
		
	}
}
