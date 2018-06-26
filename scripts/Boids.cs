using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boids: MonoBehaviour{
	private Rigidbody rb;
	public float speed;
	public Transform com;
	Color blue = Color.blue;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = GetRandomVector3 () *0.01f * speed;
		transform.rotation = Quaternion.LookRotation (rb.velocity);
		//b.velocity = new Vector3(2,1,3);

	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (com);
		//rotation.x = transform.x + 90;
		//Physics.Raycast (transform.position, com, 100.0f, 0, QueryTriggerInteraction.Collide);
		//Ray(transform.position, com.position);
		Debug.DrawRay(transform.position, com.position, blue, 0.0000000001f, false);
	}
	private void SetVel(){
		Debug.Log (rb.velocity);// Rotation doesn't work because the vector is constatly changing because its a random vector. so i need to sety the vector before trying to rotate the cone

	}
	public Vector3 GetRandomVector3(){
		return new Vector3 (Random.Range(-100.0f, 100.0f), Random.Range(-100.0f, 100.0f), Random.Range(-100.0f, 100.0f));
	}


	public void LookAt(Vector3 movement){
		/*float rotationSpeed = 5.00f;
		float xRotation = movement.x;
		float yRotation = movement.y;
		float zRotation = movement.z;*/
		//Debug.Log (xRotation + " " + yRotation + " " + zRotation);

		//Quaternion lookingAt = Quaternion.Euler (com.position.x, com.position.y, com.position.z);
		//transform.rotation = Quaternion.Slerp (transform.rotation, lookingAt, Time.deltaTime * rotationSpeed);
	}
	
}
