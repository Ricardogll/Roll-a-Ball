using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repelled_from : MonoBehaviour {

    private Rigidbody rb;
    public Vector3 repell_position;
    public float speed;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

        rb.AddForce(Vector3.Normalize(-repell_position + rb.position) * speed);

        transform.rotation = Quaternion.AngleAxis(Vector3.Angle(new Vector3(0, 0, 0), new Vector3(rb.position.x, 0, rb.position.z)), new Vector3(0, 1, 0));
    }
}
