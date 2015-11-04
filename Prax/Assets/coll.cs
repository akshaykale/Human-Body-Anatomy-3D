using UnityEngine;
using System.Collections;

public class coll : MonoBehaviour {

	public GameObject cam;
	public GameObject pos;
	//Vector3 inipos;
	public GameObject startpos;

	bool focussed=true;

	void Start () {
		//startpos = cam.transform;
		//inipos = cam.transform.position;
		//pos = GetComponentInChildren<GameObject>();	
	}

	void OnMouseDown(){
		print("hi1");
			//make all false
			//__bools.allFalse ();
	//	if(focussed)
			__bools.left_hand_elbow = !__bools.left_hand_elbow;
			
			if (__bools.left_hand_elbow == true) {
		//	focussed= false;
			InvokeRepeating ("fun", 0, 0.05f);
			print("hi2");
		} else {
			print("hi3");
			InvokeRepeating ("funBack", 0, 0.05f);
		//	focussed=true;
		}

			

		}
	public void fun(){


		cam.transform.position = Vector3.Lerp (cam.transform.position,
		                                       pos.transform.position, 10 * Time.deltaTime);
	}

	public void funBack(){
		cam.transform.position = Vector3.Lerp (cam.transform.position,startpos.transform.position, 10 * Time.deltaTime);
	}
}

