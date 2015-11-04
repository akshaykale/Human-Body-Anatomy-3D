using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour {
	Vector3 originalCameraPosition;

	public Transform body_3D;

	public Transform leftHand;
	public Transform rightHand;
	public Transform rightShoulder;
	public Transform leftShoulder;
	public Transform leftElbow;
	public Transform rightElbow;
	public Transform leftKnee;
	public Transform rightKnee;
	public Transform leftFoot;
	public Transform rightFoot;
	public Transform stomach;
	public Transform heart;
	public Transform head;

	public Transform bodyLook;
	public Transform rightHandLook;
	public Transform leftHandLook;
	public Transform rightShoulderLook;
	public Transform leftShoulderLook;
	public Transform leftElbowLook;
	public Transform rightElbowLook;
	public Transform leftKneeLook;
	public Transform rightKneeLook;
	public Transform leftFootLook;
	public Transform rightFootLook;
	public Transform stomachLook;
	public Transform heartLook;
	public Transform headLook;

	// Use this for initialization

	Vector3 opposite;

	void Start () {
		originalCameraPosition = transform.position;
		opposite = new Vector3 (0, 0, -1);
	}
	
	// Update is called once per frame
	void Update () {
		if (UIManager.leftHandBool == true) {
			transform.position = Vector3.Lerp (transform.position, leftHand.position, 4 * Time.deltaTime);
			transform.LookAt(leftHandLook);
		}
		else if (UIManager.rightHandBool == true) {
			transform.position = Vector3.Lerp (transform.position, rightHand.position, 4 * Time.deltaTime);
			transform.LookAt(rightHandLook);
		}
		else if (UIManager.rightShoulderBool == true) {
			transform.position = Vector3.Lerp (transform.position, rightShoulder.position, 4 * Time.deltaTime);
			transform.LookAt(rightShoulderLook);
		}
		else if (UIManager.leftShoulderBool == true) {
			transform.position = Vector3.Lerp (transform.position, leftShoulder.position, 4 * Time.deltaTime);
			transform.LookAt(leftShoulderLook);
		}
		else if (UIManager.headBool == true) {
			transform.position = Vector3.Lerp (transform.position, head.position, 4 * Time.deltaTime);
			transform.LookAt(headLook);
		}
		else if (UIManager.heartBool == true) {
			transform.position = Vector3.Lerp (transform.position, heart.position, 4 * Time.deltaTime);
			transform.LookAt(heartLook);
		}
		else if (UIManager.stomachBool == true) {
			transform.position = Vector3.Lerp (transform.position, stomach.position, 4 * Time.deltaTime);
			transform.LookAt(stomachLook);
		}
		else if (UIManager.leftKneeBool == true) {
			transform.position = Vector3.Lerp (transform.position, leftKnee.position, 4 * Time.deltaTime);
			transform.LookAt(leftKneeLook);
		}
		else if (UIManager.rightKneeBool == true) {
			transform.position = Vector3.Lerp (transform.position, rightKnee.position, 4 * Time.deltaTime);
			transform.LookAt(rightKneeLook);
		}
		else if (UIManager.leftElbowBool == true) {
			transform.position = Vector3.Lerp (transform.position, leftElbow.position, 4 * Time.deltaTime);
			transform.LookAt(leftElbowLook);
		}
		else if (UIManager.rightElbowBool == true) {
			transform.position = Vector3.Lerp (transform.position, rightElbow.position, 4 * Time.deltaTime);
			transform.LookAt(rightElbowLook);
		}
		else if (UIManager.leftFootBool == true) {
			transform.position = Vector3.Lerp (transform.position, leftFoot.position, 4 * Time.deltaTime);
			transform.LookAt(leftFootLook);
		}
		else if (UIManager.rightFootBool == true) {
			transform.position = Vector3.Lerp (transform.position, rightFoot.position, 4 * Time.deltaTime);
			transform.LookAt(rightFootLook);
		}
		else {
			transform.position = Vector3.Lerp(transform.position,originalCameraPosition,4*Time.deltaTime);
			transform.LookAt(bodyLook);
		}
	}
}
