using UnityEngine;
using System.Collections;

public class OffsetCenter : MonoBehaviour {
	/// Offset projection for 2 cameras in VR
	public float offset =0.0f;
	public float max_offset=0.002f;
	//public float max_offcenter_warp=0.1f;
	public Camera cameraleft;
	public Camera cameraright;

	private float correctionfactor;
	public static OffsetCenter instance;

	public void Start(){
		instance = this;
	}
	
	public void Update () {

		//cameraleft.SendMessage("set_x_offcenter_warp",-max_offcenter_warp*correctionfactor);
		//cameraright.SendMessage("set_x_offcenter_warp",max_offcenter_warp*correctionfactor);
		
	}
	
	private void SetVanishingPoint (Camera cam, Vector2 perspectiveOffset) {
		Matrix4x4 m = cam.projectionMatrix;
		float w = 2*cam.nearClipPlane/m.m00;
		float h = 2*cam.nearClipPlane/m.m11;
		
		float left = -w/2 - perspectiveOffset.x;
		float right = left+w;
		float bottom = -h/2 - perspectiveOffset.y;
		float top = bottom+h;
		
#if UNITY_ANDROID
		cam.projectionMatrix = PerspectiveOffCenter(left, right, bottom, top, cam.nearClipPlane, cam.farClipPlane);
#endif

}
	
	private static Matrix4x4 PerspectiveOffCenter (float left, float right, float bottom, float top, float near, float far)
	{
		float x =  (2.0f * near)		/ (right - left);
		float y =  (2.0f * near)		/ (top - bottom);
		float a =  (right + left)		/ (right - left);
		float b =  (top + bottom)		/ (top - bottom);
		float c = -(far + near)		/ (far - near);
		float d = -(2.0f * far * near) / (far - near);
		float e = -1.0f;
		
		Matrix4x4 m = new Matrix4x4();
		m[0,0] =   x;  m[0,1] = 0.0f;  m[0,2] = a;   m[0,3] = 0.0f;
		m[1,0] = 0.0f;  m[1,1] =   y;  m[1,2] = b;   m[1,3] = 0.0f;
		m[2,0] = 0.0f;  m[2,1] = 0.0f;  m[2,2] = c;   m[2,3] =   d;
		m[3,0] = 0.0f;  m[3,1] = 0.0f;  m[3,2] = e;   m[3,3] = 0.0f;
		return m;
	}

	public void setCorrectionFactor(float fac){
		//offset=max_offset*fac;
		offset = fac * 10;
		correctionfactor=fac;
		SetVanishingPoint(cameraleft, new Vector2(offset, 0.0f));
		SetVanishingPoint(cameraright, new Vector2(-offset, 0.0f));
	}

}
