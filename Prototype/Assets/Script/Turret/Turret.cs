using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour {
	
	
	public Transform missilePrefab,explosionPrefab;
	public Transform targetTr;
	Transform myTr;
	float fireTime = 1f,fireTimer = 0;
	Transform spawnPointTr;
	float range = 20f;
	
	
	// Use this for initialization
	void Start () {
		myTr = transform;
		spawnPointTr = myTr.Find("MissileSpawnPoint");
		
	}
	
	// Update is called once per frame
	void Update () {
		fireTimer += Time.deltaTime;
		if(fireTimer > fireTime && Vector3.Distance(myTr.position,targetTr.position) < range){
			fireTimer = 0;
			fireTime = 5f + Random.Range(-1.5f,1.5f);
			Transform n = Instantiate(missilePrefab,spawnPointTr.position,spawnPointTr.rotation) as Transform;
			Transform explosion = Instantiate(explosionPrefab,spawnPointTr.position,spawnPointTr.rotation) as Transform;
		}
		
		myTr.rotation = Quaternion.LookRotation(targetTr.position - myTr.position);
		
	}
}
