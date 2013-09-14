using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	float deathTimer = 0.3f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		deathTimer -= Time.deltaTime;
		if(deathTimer < 0){
			particleSystem.enableEmission = false;
		}
		if(deathTimer < -1f){
			Destroy(gameObject);
		}
	
	}
}
