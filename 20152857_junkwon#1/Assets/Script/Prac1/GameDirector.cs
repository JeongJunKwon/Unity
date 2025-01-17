﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace prac1 {
	public class GameDirector : MonoBehaviour {

		GameObject player;
		GameObject flag;
		GameObject distance;
		// Use this for initialization
		void Start () {
			player = GameObject.Find("car");
			flag = GameObject.Find("flag");
			distance = GameObject.Find("Distance");
		}
		
		// Update is called once per frame
		void Update () {
			float length = this.flag.transform.position.x - this.player.transform.position.x;
			if(length >= 1)
			{
				this.distance.GetComponent<Text>().text = "Distance: " + (length - 1).ToString("N2");
			} else 
			{
				this.distance.GetComponent<Text>().text = "Game Over!";
			}
			
		}
	}
}
