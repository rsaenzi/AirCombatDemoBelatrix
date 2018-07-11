using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterSimpleMotion : MonoBehaviour {

    float verticalSpeed = 18;
    float horizontalSpeed = 15;
    float forceValue = 25;
    ForceMode mode = ForceMode.Acceleration;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey(KeyCode.UpArrow)) {
            //this.transform.Translate(Vector3.up * Time.deltaTime * verticalSpeed);
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * forceValue, mode);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            //this.transform.Translate(Vector3.down * Time.deltaTime * verticalSpeed);
            this.GetComponent<Rigidbody>().AddForce(Vector3.down * forceValue, mode);
        }

        if (Input.GetKey(KeyCode.LeftArrow)){
            //this.transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
            this.GetComponent<Rigidbody>().AddForce(Vector3.left * forceValue, mode);
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            //this.transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed);
            this.GetComponent<Rigidbody>().AddForce(Vector3.right * forceValue, mode);
        }
    }
}
