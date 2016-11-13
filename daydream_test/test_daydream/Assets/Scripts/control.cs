using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {
	// Use this for initialization

	public float speed;
    Vector3 moveDir = Vector3.zero;

    void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //moveDir.x = InputManager.GetAxis("Horizontal");

        if (Input.GetKey("left")) {
            Debug.Log("left");
            var d = 2.0f * speed * Time.deltaTime;
            transform.Rotate(new Vector3(0.0f,-d,0.0f));
            //var d = (GvrController.TouchPos.y - 0.5f) * 2.0f * speed * Time.deltaTime;
            //transform.Rotate(new Vector3(0.0f,d,0.0f));
        }

        if (Input.GetKey("right"))
        {
            Debug.Log("right");
            var d = 2.0f * speed * Time.deltaTime;
            transform.Rotate(new Vector3(0.0f, d, 0.0f));
            //var d = (GvrController.TouchPos.y - 0.5f) * 2.0f * speed * Time.deltaTime;
            //transform.Rotate(new Vector3(0.0f,d,0.0f));
        }

        if (Input.GetKey("up"))
        {
            Debug.Log("up");
            var d = 2.0f * speed * Time.deltaTime;
            transform.Rotate(new Vector3(-d, 0.0f, 0.0f));
            //var d = (GvrController.TouchPos.y - 0.5f) * 2.0f * speed * Time.deltaTime;
            //transform.Rotate(new Vector3(0.0f,d,0.0f));
        }

        if (Input.GetKey("down"))
        {
            Debug.Log("down");
            var d = 2.0f * speed * Time.deltaTime;
            transform.Rotate(new Vector3(d, 0.0f, 0.0f));
            //var d = (GvrController.TouchPos.y - 0.5f) * 2.0f * speed * Time.deltaTime;
            //transform.Rotate(new Vector3(0.0f,d,0.0f));
        }
    }
}
