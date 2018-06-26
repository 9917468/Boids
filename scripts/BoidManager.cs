using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoidManager : MonoBehaviour {

	public Transform com;
	private Random r;
	//public float rangeLimit;
	public int spawnAmount;
	public GameObject boid;
	private GameObject[] boids;
	public float max;
	public float min;
	public Vector3 vel;
	void Start () {
		boids = new GameObject[spawnAmount];
		SpawnBoids ();
		CalculateCenterOfMass ();

		//rb = GetComponent<Rigidbody> ();
		//velocity
		//rb.velocity = GetRandomVector3().normalized;
		//Location
		//transform.position = GetRandomVector3();

	}
	
	// Update is called once per frame
	void Update () {
		CalculateCenterOfMass ();
	}

	public void SpawnBoids(){
		for(int i=0;i<spawnAmount;i++){
			boids[i] = Instantiate (boid, GetRandomVector3(), Quaternion.identity);
		}
	}

	public Vector3 GetRandomVector3(){
		vel = new Vector3 (Random.Range(min, max), Random.Range(min, max), Random.Range(min, max));//cahnge to public limit
		return vel;
	}
	public void CalculateCenterOfMass(){
		float totalX = 0;
		float totalY = 0; 
		float totalZ = 0;
		float avgX = 0;
		float avgY = 0; 
		float avgZ = 0;

		for(int i=0;i<spawnAmount;i++){
			totalX += boids [i].transform.position.x;
			totalY += boids [i].transform.position.y;
			totalZ += boids [i].transform.position.z;
		}
		avgX = totalX / spawnAmount;
		avgY = totalY / spawnAmount;
		avgZ = totalZ / spawnAmount;
		Vector3 centerOfMass = new Vector3(avgX, avgY, avgZ);
		Debug.Log (centerOfMass);
		com.position = centerOfMass;
	}
}
