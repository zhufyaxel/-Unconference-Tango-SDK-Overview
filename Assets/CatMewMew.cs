using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMewMew : MonoBehaviour {
    public GameObject cat;
    public TangoPointCloud pointCloud;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount == 1)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Ended) {
                PlaceCat(t.position);
            }
        }
	}

    public void PlaceCat(Vector2 touchPosition)
    {
        Camera cam = Camera.main;
        Vector3 planeCenter;
        Plane plane;
        if (!pointCloud.FindPlane(cam,touchPosition,out planeCenter,out plane))
        {
            Debug.Log("Sorry, Sorry, Sorry, I'm so Sorry");
        }
        else
        {
            Vector3 up = plane.normal;
            Vector3 right = Vector3.Cross(plane.normal, cam.transform.forward).normalized;
            Vector3 forward = Vector3.Cross(right, up).normalized;
            Instantiate(cat, planeCenter, Quaternion.LookRotation(forward, up));
                
        }
    }
}
