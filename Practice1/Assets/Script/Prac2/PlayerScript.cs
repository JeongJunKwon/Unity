using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace prac2 {
    public class PlayerScript : MonoBehaviour
    {   
        private GameObject director;
        // Start is called before the first frame update
        void Start()
        {
            director = GameObject.Find("GameDirector");
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                onRight();
                
            } else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
            onLeft();
            }
        }

        public void onLeft()
        {
            if(this.transform.position.x <= -2.5f) {
                    Debug.Log("Can't move!");
                } else {
                    this.transform.Translate(Vector2.left);
                }
        }

        public void onRight()
        {
            if(this.transform.position.x >= 2.5f) {
                    Debug.Log("Can't move!");
                } else {
                    this.transform.Translate(Vector2.right);
                }
        }

        void OnTriggerEnter2D(Collider2D other) {
            director.GetComponent<GameDirector>().DecreseHeart();
        }
    }
}
