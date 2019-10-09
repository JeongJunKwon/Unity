using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyScript : MonoBehaviour
{
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)) {
            rigidbody.AddForce(Vector3.forward * 300 * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.DownArrow)) {
            rigidbody.AddForce(Vector3.back * 300 * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.RightArrow)) {
            rigidbody.AddForce(Vector3.right * 300 * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.LeftArrow)) {
            rigidbody.AddForce(Vector3.left * 300 * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.U)) {
            rigidbody.AddForce(Vector3.up * 300 * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D)) {
            rigidbody.AddForce(Vector3.down * 300 * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.Keypad0)) {
            Physics.gravity = Vector3.zero;
        }

        if(Input.GetKeyDown(KeyCode.Keypad8)) {
            Physics.gravity = Vector3.up;
        }

        if(Input.GetKeyDown(KeyCode.Keypad2)) {
            Physics.gravity = Vector3.down;
        }
        
    }
}
