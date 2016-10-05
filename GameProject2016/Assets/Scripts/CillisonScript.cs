using UnityEngine;
using System.Collections;

public class CillisonScript : MonoBehaviour {
	void OnCollisionEnter ( Collision collision ){
		Debug.Log ("Enter Called");

		if (collision.gameObject.name == "wall") {
			Destroy (collision.gameObject);
		}
	}
}
