﻿using UnityEngine;
using System.Collections;

public class FOV : MonoBehaviour {

<<<<<<< HEAD

=======
>>>>>>> 3b1730ba744f9d7bf2dff90231bf0f64e4ce60bf
	public float fov = 90f;
	public bool warp,startwarp = false;

	// Use this for initialization

	void Start (){
		Camera.main.fieldOfView = 60;		 
		warp = false;
		startwarp = false;




	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("space") && MoveForward.speed >= 50 ) {
			warp = true;
		}
		if (warp == true) {
			Warp ();
		}
		if (Camera.main.fieldOfView >= 350) {
			int i = Application.loadedLevel;
			Application.LoadLevel(i + 1);
			}

		}


	void Warp(){
		Camera.main.fieldOfView = Mathf.Lerp (Camera.main.fieldOfView, 400, 1 * Time.deltaTime);		 
	}


}
<<<<<<< HEAD
=======

>>>>>>> 3b1730ba744f9d7bf2dff90231bf0f64e4ce60bf
