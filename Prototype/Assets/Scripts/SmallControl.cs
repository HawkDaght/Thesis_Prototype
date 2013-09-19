using UnityEngine;
using System.Collections;

public class SmallControl : MonoBehaviour {
	float smallSpeed = 0.1f;
	//Transform myBig;
	// Use this for initialization
	void Start () {
	//myBig = GameObject.FindGameObjectWithTag("Big").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(!BigControl.contact){
	if(Input.GetKey("w")){
			transform.position += new Vector3(0,0,smallSpeed);
		}
	if(Input.GetKey("s")){
			transform.position += new Vector3(0,0,-smallSpeed);
		}
	if(Input.GetKey("a")){
			transform.position += new Vector3(-smallSpeed,0,0);
		}
	if(Input.GetKey("d")){
			transform.position += new Vector3(smallSpeed,0,0);
		}
	}
	}
}
