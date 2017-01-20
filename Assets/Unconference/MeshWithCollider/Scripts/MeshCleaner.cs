using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshCleaner : MonoBehaviour {
    public Material visiable;
    public Material invisiable;

    private bool isActive;
    // Use this for initialization
    void Start () {
        isActive = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void changeActive()
    {
        isActive = !isActive;
        if (isActive)
        {
            GetComponent<MeshRenderer>().material = visiable;
        }
        else
        {
            GetComponent<MeshRenderer>().material = invisiable;
        }
    }
}
