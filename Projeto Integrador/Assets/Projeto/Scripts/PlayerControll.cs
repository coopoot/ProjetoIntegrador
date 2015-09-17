using UnityEngine;
using System.Collections;

public class PlayerControll : MonoBehaviour {

	[SerializeField]private float speed=0,rotacao=0,pulo=0;
	[SerializeField]private Rigidbody rb;
	

	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		controlePc ();

	
	}
	private void controlePc(){

		float vertical=Input.GetAxis("Vertical");
		float horizontal=Input.GetAxis("Horizontal");
	
		if (horizontal > 0) {
			transform.Translate (speed * Time.deltaTime, 0, 0);
			transform.Rotate(0,rotacao*Time.deltaTime,0);
		}
		if (horizontal < 0) {
			transform.Translate (-speed * Time.deltaTime, 0, 0);
			transform.Rotate(0,-rotacao*Time.deltaTime,0);
		}
		if (vertical > 0) {
			transform.Translate (0, 0, speed * Time.deltaTime);
		}
		if (vertical < 0) {
			transform.Translate (0, 0, -speed * Time.deltaTime);
		} 
		if (Input.GetKeyDown(KeyCode.Space)&&transform.position.y<2) {
			rb.AddForce(transform.up*pulo);
		} 
	}
}
