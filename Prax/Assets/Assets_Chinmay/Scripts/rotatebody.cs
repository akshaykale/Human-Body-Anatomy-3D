using UnityEngine;
using System.Collections;

public class rotatebody: MonoBehaviour {
	float horizontalSpeed=4f;
	float verticalSpeed=4f;

	void Update() {
		if (Input.GetMouseButton (0)) {
			float h = horizontalSpeed * Input.GetAxis("Mouse X");
			float v = verticalSpeed * Input.GetAxis("Mouse Y");
			transform.Rotate(-v,-h,0);
		}
	}
}