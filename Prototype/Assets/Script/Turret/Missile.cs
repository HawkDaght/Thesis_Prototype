using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour {
	Transform myTr;
	float speed = 3f;
	public Transform explosionPrefab;
	// Use this for initialization
	void Start () {
		myTr = transform;
	}
	
	// Update is called once per frame
	void Update () {
		myTr.Translate(Vector3.forward * speed * Time.deltaTime);
	
	}
	
	void OnTriggerEnter(Collider col){
		//if(col.gameObject.tag == "Player"){
			Destroy(gameObject);
			Transform explosion = Instantiate(explosionPrefab,myTr.position,myTr.rotation) as Transform;
		//}
	}
}
