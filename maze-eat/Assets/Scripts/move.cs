using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    public float speed = 1.0f;
    CharacterController cc;
	// Use this for initialization
	void Start () {
        cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
            cc.SimpleMove(Vector3.forward * speed);
        else if (Input.GetKey(KeyCode.S))
            cc.SimpleMove(Vector3.back * speed);
        else if (Input.GetKey(KeyCode.A))
            cc.SimpleMove(Vector3.left * speed);
        else if (Input.GetKey(KeyCode.D))
            cc.SimpleMove(Vector3.right * speed);
	}
}
