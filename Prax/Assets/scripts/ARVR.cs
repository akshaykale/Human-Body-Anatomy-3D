using UnityEngine;
using System.Collections;

public class ARVR : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AR(){
		Application.LoadLevel ("AR");
	}
	public void VR(){
		Application.LoadLevel ("DemoScene");
	}
	public void Home(){
		Application.LoadLevel ("starting");
		print ("hey");
	}
	public void Exit(){
		Application.Quit();
	}
	public void Skel(){
		Application.LoadLevel ("skel");
	}
}
