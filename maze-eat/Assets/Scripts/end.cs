using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour {
    public GameObject plane1;
    public GameObject plane2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        other.transform.DetachChildren();
        Destroy(other.GetComponent<move>());
        Destroy(transform.gameObject);
        Destroy(plane1);
        Destroy(plane2);
        Destroy(other.GetComponent<CharacterController>());
        other.gameObject.AddComponent<Rigidbody>();
    }
}
