using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace prac2 {
    public class ArrowScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            float rnd = Random.Range(-2.5f, 2.5f);
            this.transform.position = new Vector3(rnd, 3.0f, 0.0f);
        }

        // Update is called once per frame
        void Update()
        {
            this.transform.Translate(Vector3.down * Time.deltaTime);
            if(this.transform.position.y <= -3.0f) {
                Destroy(gameObject);
            }
        }

        void OnTriggerEnter2D(Collider2D ohter) {
            Destroy(this.gameObject);
        }
    }
}   
