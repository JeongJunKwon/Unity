using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace prac2 {
    public class GameDirector : MonoBehaviour
    {
        private List<GameObject> hearts;
        private GameObject heartArr;
        private bool isOver;
        private int life;

        private Text gameoverText;

        // Start is called before the first frame update
        void Start()
        {
            heartArr = GameObject.Find("hearts");
            hearts = new List<GameObject>();
            for(int i = 0; i <  5; i++) {
                hearts.Add(heartArr.transform.GetChild(i).gameObject);
            }

            isOver = false;
            life = hearts.Count - 1;
            gameoverText = GameObject.Find("GameOver").GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            if(hearts.Count == 0) {
                isOver = !isOver;
            }

            if(isOver) {
                gameoverText.text = "GameOver!";
                Time.timeScale = 0;
            }
        }

        public void DecreseHeart() {
            Destroy(hearts[life]);
            hearts.RemoveAt(life);
            life--;
        }
    }
}
