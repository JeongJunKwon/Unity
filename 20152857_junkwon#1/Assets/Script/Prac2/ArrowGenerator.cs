using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace prac2 {

    public class ArrowGenerator : MonoBehaviour
    {
        public GameObject arrow;
        private float time;
        private bool isTimeout;
        // Start is called before the first frame update
        void Start()
        {
            isTimeout = false;
        }

        // Update is called once per frame
        void Update()
        {   if(!isTimeout) {
                Instantiate(arrow);
                time = 2.0f;
                isTimeout = true;
            }
            time -= Time.deltaTime;
            if(time < 0) {
                isTimeout = false;
            }
        }
    }
}
