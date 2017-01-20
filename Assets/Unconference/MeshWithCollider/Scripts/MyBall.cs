using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour {
    public GameObject ball;
    public float speed = 5.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            throwBall();
            Debug.Log("space");
        }
        if (Input.touchCount == 1)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                throwBall();            
            }
        }
    }

    public void throwBall()
    {
        Camera cam = Camera.main;
        Vector3 pos = cam.transform.position - (cam.transform.up * ball.transform.localScale.y);
        GameObject newBall = (GameObject)Instantiate(ball);
        newBall.transform.position = pos;
        newBall.GetComponent<Rigidbody>().velocity = (cam.transform.forward * speed) + (cam.transform.up * speed / 2);

    }
}
