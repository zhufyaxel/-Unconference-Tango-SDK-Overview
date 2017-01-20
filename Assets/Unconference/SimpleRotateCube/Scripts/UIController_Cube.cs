using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController_Cube : MonoBehaviour {
    public GameObject Trial;

    private bool isActive = true;
    // Use this for initialization
	void Start () {
        Trial.SetActive(isActive);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setTrial()
    {
        isActive = !isActive;
        Trial.SetActive(isActive);
    }
}
