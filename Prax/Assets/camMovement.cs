using UnityEngine;
using System.Collections;

public class camMovement : MonoBehaviour {
	public Transform left_hand_elbow;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp (transform.position, left_hand_elbow.position, 4 * Time.deltaTime);
	}
}
