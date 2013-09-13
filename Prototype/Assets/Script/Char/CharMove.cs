using UnityEngine;
using System.Collections;

public class CharMove : MonoBehaviour {
	Transform myTr;
	CharacterController myController;
	Vector3 moveDirection;
	float speed = 5f;
	// Use this for initialization
	void Start () {
		myTr = transform;
		myController = GetComponent<CharacterController>();
		
	}
	
	// Update is called once per frame
	void Update () {
		moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		myTr.position = new Vector3(myTr.position.x,0,myTr.position.z);
		
		myController.Move(moveDirection * Time.deltaTime * speed);
	}
}
