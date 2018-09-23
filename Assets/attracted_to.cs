using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attracted_to : MonoBehaviour {

    private Rigidbody rb;
    private Rigidbody follow_this_object_rb;
    public Vector3 goal;
    public float speed;
    public GameObject follow_this_object;
    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();
        if(follow_this_object)
            follow_this_object_rb = follow_this_object.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        
        //HACER QUE CILINDRO SIGA A ESFERA0
        if(follow_this_object)
            rb.AddForce(Vector3.Normalize(follow_this_object_rb.position - rb.position) * speed);
        else
            rb.AddForce(Vector3.Normalize(goal - rb.position)*speed);

        //Vector3.Angle(new Vector3(0, 0, 0), new Vector3(1, 0, 1));
        // Vector3 direction = goal - rb.position;
        //Quaternion toRotation = Quaternion.FromToRotation(transform.up, direction);
        //transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, rotation_speed * Time.time);
        if (follow_this_object)
            transform.rotation = Quaternion.AngleAxis(Vector3.Angle(new Vector3(follow_this_object_rb.position.x, 0, follow_this_object_rb.position.z), new Vector3(rb.position.x, 0, rb.position.z)), new Vector3(0, 1, 0));

        else
            // transform.Rotate(new Vector3(1, 0, 0), Vector3.Angle(new Vector3(0, 0, 0), new Vector3(rb.position.x, 0, rb.position.z)));
            //Quaternion aux = Quaternion.AngleAxis(Vector3.Angle(new Vector3(0, 0, 0), new Vector3(rb.position.x, 0, rb.position.z)), new Vector3(0, 1, 0));
            transform.rotation = Quaternion.AngleAxis(Vector3.Angle(new Vector3(goal.x, 0, goal.z), new Vector3(rb.position.x, 0, rb.position.z)), new Vector3(0, 1, 0));
        // rb.AddForce(Vector3.Normalize(goal - rb.position));
        /* Vector3 direction = otherObject.position - transform.position;
 Quaternion toRotation = Quaternion.FromToRotation(transform.up, direction);
 transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, speed * Time.time);*/
    }
}
