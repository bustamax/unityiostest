using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracanvas : MonoBehaviour {
public GameObject myCanvas;
	// Use this for initialization
	void Start () {
		GameObject canvas = Instantiate (myCanvas) as GameObject;
         canvas.GetComponent<Canvas> ().worldCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
