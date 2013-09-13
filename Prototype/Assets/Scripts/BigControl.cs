using UnityEngine;
using System.Collections;

public class BigControl : MonoBehaviour {
	float bigSpeed = 0.3f;
	static public bool contact;
	Transform mySmall;
	
	// Use this for initialization
	void Start () {
	mySmall = GameObject.FindGameObjectWithTag("Small").transform;
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKey("up")){
			transform.position += new Vector3(0,0,bigSpeed);
		}
	if(Input.GetKey("down")){
			transform.position += new Vector3(0,0,-bigSpeed);
		}
	if(Input.GetKey("left")){
			transform.position += new Vector3(-bigSpeed,0,0);
		}
	if(Input.GetKey("right")){
			transform.position += new Vector3(bigSpeed,0,0);
		}
	if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), 1f)){
			mySmall.transform.position += new Vector3(0,0,bigSpeed);
		}
		else{
		mySmall.transform.position += new Vector3(0,0,0);	
		}
	if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), 1f)){
			mySmall.transform.position += new Vector3(0,0,-bigSpeed);
		}else{
		mySmall.transform.position += new Vector3(0,0,0);	
		}
	if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), 1f)){
			mySmall.transform.position += new Vector3(-bigSpeed,0,0);
		}else{
		mySmall.transform.position += new Vector3(0,0,0);	
		}
	if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), 1f)){
			mySmall.transform.position += new Vector3(bigSpeed,0,0);
		}else{
		mySmall.transform.position += new Vector3(0,0,0);	
		}
	}
	
	void OnTriggerEnter(Collider other){
	if(other.gameObject.tag == "Small"){
			Debug.Log("hit");
			contact = true;
		}
	}
	void OnTriggerExit(Collider other){
			if(other.gameObject.tag == "Small"){
			contact = false;
		}
	}
	
}
