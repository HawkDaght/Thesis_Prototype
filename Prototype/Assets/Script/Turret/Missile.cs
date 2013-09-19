using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour {
	Transform myTr;
	float speed = 3f;
	public Transform explosionPrefab;
	Transform myBig;
	Transform mySmall;
	
	// Use this for initialization
	void Start () {
		myTr = transform;
		myBig = GameObject.FindGameObjectWithTag("Big").transform;
		mySmall = GameObject.FindGameObjectWithTag("Small").transform;
	}
	
	// Update is called once per frame
	void Update () {
		myTr.Translate(Vector3.forward * speed * Time.deltaTime);
	
	}
	
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Big"){
			myBig.localScale-= new Vector3(0.1f,0.1f,0.1f);
		}
		if(col.gameObject.tag == "Small"){
			
			mySmall.localScale-= new Vector3(0.1f,0.1f,0.1f);
			
		}
		Destroy(gameObject);
		Transform explosion = Instantiate(explosionPrefab,myTr.position,myTr.rotation) as Transform;
	}
}
