using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	public static float speed;
	public float cruisespeed = 30.0f;

	void Start(){
		speed = 1;

	}
	// Update is called once per frame
	void Update () {
		if (speed < cruisespeed) {
			speed  += 0.1f;
		}
		transform.position += transform.forward*speed*Time.deltaTime;
		if (speed >= 50) {
			print (speed);
		}
	}
}
