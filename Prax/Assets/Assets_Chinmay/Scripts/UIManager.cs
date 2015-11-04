using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	public static bool leftHandBool=false;
	public static bool rightHandBool=false;
	public static bool leftShoulderBool=false;
	public static bool rightShoulderBool=false;
	public static bool rightKneeBool = false;
	public static bool leftKneeBool = false;
	public static bool heartBool=false;
	public static bool stomachBool=false;
	public static bool headBool=false;
	public static bool leftElbowBool=false;
	public static bool rightElbowBool=false;
	public static bool leftFootBool=false;
	public static bool rightFootBool=false;
	// Use this for initialization

	public Button LHand;
	public Button RHand;
	public Button LElbow;
	public Button RElbow;
	public Button LShoulder;
	public Button RShoulder;
	public Button LKnee;
	public Button RKnee;
	public Button LFoot;
	public Button RFoot;
	public Button Head;
	public Button Heart;
	public Button Stomach;

	Animator anim;


	void Start () {

	}
	
	// Update is called once per frame
	public void moveToLeftHand () {
		leftHandBool = !leftHandBool;
		rightHandBool = false;
		leftShoulderBool=false;
		rightShoulderBool=false;
		headBool = false;
		heartBool = false;
		stomachBool = false;
		leftKneeBool = false;
		rightKneeBool = false;
		rightElbowBool = false;
		leftElbowBool = false;
		leftFootBool = false;
		rightFootBool = false;
		if (leftHandBool)
			disableAll ();
		else
			enableAll ();
		Color setcolor = LHand.image.color;
		setcolor.a = 1f;
		LHand.image.color = setcolor;
	}
	public void moveToRightHand () {
		rightHandBool = !rightHandBool;
		leftHandBool = false;
		leftShoulderBool=false;
		rightShoulderBool=false;
		headBool = false;
		heartBool = false;
		stomachBool = false;
		leftKneeBool = false;
		rightKneeBool = false;
		rightElbowBool = false;
		leftElbowBool = false;
		leftFootBool = false;
		rightFootBool = false;
		if (rightHandBool)
			disableAll ();
		else
			enableAll ();
		Color setcolor = RHand.image.color;
		setcolor.a = 1f;
		RHand.image.color = setcolor;
	}
	public void moveToLeftShoulder(){
		leftShoulderBool= !leftShoulderBool;
		rightHandBool = false;
		leftHandBool = false;
		rightShoulderBool=false;
		headBool = false;
		heartBool = false;
		stomachBool = false;
		leftKneeBool = false;
		rightKneeBool = false;
		rightElbowBool = false;
		leftElbowBool = false;
		leftFootBool = false;
		rightFootBool = false;
		if (leftShoulderBool)
			disableAll ();
		else
			enableAll ();
		Color setcolor = LShoulder.image.color;
		setcolor.a = 1f;
		LShoulder.image.color = setcolor;
	}
	public void moveToRightShoulder(){
		rightShoulderBool= !rightShoulderBool;
		rightHandBool = false;
		leftHandBool = false;
		leftShoulderBool=false;
		headBool = false;
		heartBool = false;
		stomachBool = false;
		leftKneeBool = false;
		rightKneeBool = false;
		rightElbowBool = false;
		leftElbowBool = false;
		leftFootBool = false;
		rightFootBool = false;
		if (rightShoulderBool)
			disableAll ();
		else
			enableAll ();
		Color setcolor = RShoulder.image.color;
		setcolor.a = 1f;
		RShoulder.image.color = setcolor;
	}
	public void moveToHead(){
		headBool = !headBool;
		rightShoulderBool= false;
		rightHandBool = false;
		leftHandBool = false;
		leftShoulderBool=false;
		heartBool = false;
		stomachBool = false;
		leftKneeBool = false;
		rightKneeBool = false;
		rightElbowBool = false;
		leftElbowBool = false;
		leftFootBool = false;
		rightFootBool = false;
		if (headBool)
			disableAll ();
		else
			enableAll ();
		Color setcolor = Head.image.color;
		setcolor.a = 1f;
		Head.image.color = setcolor;
	}
	public void moveToStomach(){
		stomachBool = !stomachBool;
		rightShoulderBool= false;
		rightHandBool = false;
		leftHandBool = false;
		leftShoulderBool=false;
		headBool = false;
		heartBool = false;
		leftKneeBool = false;
		rightKneeBool = false;
		rightElbowBool = false;
		leftElbowBool = false;
		leftFootBool = false;
		rightFootBool = false;
		if (stomachBool)
			disableAll ();
		else
			enableAll ();
		Color setcolor = Stomach.image.color;
		setcolor.a = 1f;
		Stomach.image.color = setcolor;
	}
	public void moveToHeart(){
		heartBool = !heartBool;
		rightShoulderBool= false;
		rightHandBool = false;
		leftHandBool = false;
		leftShoulderBool=false;
		headBool = false;
		stomachBool = false;
		leftKneeBool = false;
		rightKneeBool = false;
		rightElbowBool = false;
		leftElbowBool = false;
		leftFootBool = false;
		rightFootBool = false;
		if (heartBool)
			disableAll ();
		else
			enableAll ();
		Color setcolor = Heart.image.color;
		setcolor.a = 1f;
		Heart.image.color = setcolor;
	}
	public void moveToRightKnee(){
		rightKneeBool = !rightKneeBool;
		leftKneeBool = false;
		rightShoulderBool= false;
		rightHandBool = false;
		leftHandBool = false;
		leftShoulderBool=false;
		headBool = false;
		stomachBool = false;
		heartBool = false;
		rightElbowBool = false;
		leftElbowBool = false;
		leftFootBool = false;
		rightFootBool = false;
		if (rightKneeBool)
			disableAll ();
		else
			enableAll ();
		Color setcolor = RKnee.image.color;
		setcolor.a = 1f;
		RKnee.image.color = setcolor;
	}
	public void moveToLeftKnee(){
		leftKneeBool = !leftKneeBool;
		rightKneeBool = false;
		rightShoulderBool= false;
		rightHandBool = false;
		leftHandBool = false;
		leftShoulderBool=false;
		headBool = false;
		stomachBool = false;
		heartBool = false;
		rightElbowBool = false;
		leftElbowBool = false;
		leftFootBool = false;
		rightFootBool = false;
		if (leftKneeBool)
			disableAll ();
		else
			enableAll ();
		Color setcolor = LKnee.image.color;
		setcolor.a = 1f;
		LKnee.image.color = setcolor;
		
	}
	public void moveToLeftElbow(){
		leftElbowBool = !leftElbowBool;
		rightElbowBool = false;
		leftKneeBool = false;
		rightKneeBool = false;
		rightShoulderBool= false;
		rightHandBool = false;
		leftHandBool = false;
		leftShoulderBool=false;
		headBool = false;
		stomachBool = false;
		heartBool = false;
		leftFootBool = false;
		rightFootBool = false;
		if (leftElbowBool)
			disableAll ();
		else
			enableAll ();
		Color setcolor = LElbow.image.color;
		setcolor.a = 1f;
		LElbow.image.color = setcolor;
	}
	public void moveToRightElbow(){
		rightElbowBool = !rightElbowBool;
		leftElbowBool = false;
		leftKneeBool = false;
		rightKneeBool = false;
		rightShoulderBool= false;
		rightHandBool = false;
		leftHandBool = false;
		leftShoulderBool=false;
		headBool = false;
		stomachBool = false;
		heartBool = false;
		leftFootBool = false;
		rightFootBool = false;
		if (rightElbowBool)
			disableAll ();
		else
			enableAll ();
		Color setcolor = RElbow.image.color;
		setcolor.a = 1f;
		RElbow.image.color = setcolor;
	}
	public void moveToLeftFoot(){
		leftFootBool = !leftFootBool;
		rightFootBool = false;
		rightElbowBool = false;
		leftElbowBool = false;
		leftKneeBool = false;
		rightKneeBool = false;
		rightShoulderBool= false;
		rightHandBool = false;
		leftHandBool = false;
		leftShoulderBool=false;
		headBool = false;
		stomachBool = false;
		heartBool = false;
		if (leftFootBool)
			disableAll ();
		else
			enableAll ();
		Color setcolor = LFoot.image.color;
		setcolor.a = 1f;
		LFoot.image.color = setcolor;
	}
	public void moveToRightFoot(){
		rightFootBool = !rightFootBool;
		leftFootBool = false;
		rightElbowBool = false;
		leftElbowBool = false;
		leftKneeBool = false;
		rightKneeBool = false;
		rightShoulderBool= false;
		rightHandBool = false;
		leftHandBool = false;
		leftShoulderBool=false;
		headBool = false;
		stomachBool = false;
		heartBool = false;
		if (rightFootBool)
			disableAll ();
		else
			enableAll ();
		Color setcolor = RFoot.image.color;
		setcolor.a = 1f;
		RFoot.image.color = setcolor;
	}

	void disableAll(){
		Color noColor = LHand.image.color;
		noColor.a = 0f;
		LHand.image.color=noColor;
		RHand.image.color=noColor;
		LElbow.image.color=noColor;
		RElbow.image.color=noColor;
		LShoulder.image.color=noColor;
		RShoulder.image.color=noColor;
		LKnee.image.color=noColor;
		RKnee.image.color=noColor;
		LFoot.image.color=noColor;
		RFoot.image.color=noColor;
		Head.image.color=noColor;
		Heart.image.color=noColor;
		Stomach.image.color=noColor;
	}
	void enableAll(){
		Color noColor = LHand.image.color;
		noColor.a = 1f;
		LHand.image.color=noColor;
		RHand.image.color=noColor;
		LElbow.image.color=noColor;
		RElbow.image.color=noColor;
		LShoulder.image.color=noColor;
		RShoulder.image.color=noColor;
		LKnee.image.color=noColor;
		RKnee.image.color=noColor;
		LFoot.image.color=noColor;
		RFoot.image.color=noColor;
		Head.image.color=noColor;
		Heart.image.color=noColor;
		Stomach.image.color=noColor;
	}

	public void OnScreenShotClick(){
		//screen shot capture 
		Application.CaptureScreenshot ("screenshot.jpg");

		//instantiate the class Intent
		AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
		
		//instantiate the object Intent
		AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");
		
		//call setAction setting ACTION_SEND as parameter
		intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
		
		//instantiate the class Uri
		AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");
		
		//instantiate the object Uri with the parse of the url's file
		AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject>("parse","screenshot.jpg");
		
		//call putExtra with the uri object of the file
		intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_STREAM"), uriObject);
		
		//set the type of file
		intentObject.Call<AndroidJavaObject>("setType", "image/jpeg");
		
		//instantiate the class UnityPlayer
		AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		
		//instantiate the object currentActivity
		AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");
		
		//call the activity with our Intent
		currentActivity.Call("startActivity", intentObject);

		Application.LoadLevel ("sceneQue");
	}

}
