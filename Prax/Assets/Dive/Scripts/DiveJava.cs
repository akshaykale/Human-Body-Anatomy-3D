using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System.IO;
using System;

public class DiveJava : MonoBehaviour {

	private string cacheDir = "Push to get cache dir";
	private string startURI = "Push to get startURI";
	private static int start_once;
	public float time_since_last_fullscreen=0;
	public bool autoCorrectOffset=true;
	public bool debugMetrics=false;

	private static float density;
	private static int densitydpi;
	private static int vpixels;
	private static int hpixels;
	private static float scaledDensity;
	private static float ydpi;
	private static float xdpi;
	private static float xmm;
	private static float ymm;
	private static float mmdist;
	private static GameObject infotext;
	private static float correction_factor = 0.0f;

	private static DiveJava instance;

	private static bool initiated = false;

#if UNITY_ANDROID
	private static AndroidJavaClass javadivepluginclass;
	private static AndroidJavaClass javaunityplayerclass;
	private static AndroidJavaObject currentactivity;
	public static AndroidJavaObject javadiveplugininstance;
	
	private static AndroidJavaObject windowManagerInstance;
	private static AndroidJavaObject displayInstance;
	private static AndroidJavaObject metricsClass;
	private static AndroidJavaObject metricsInstance;

#endif

	void Start(){
		if (!initiated) {
			init ();
		}
	}



	public void Update(){
	
		hpixels=Screen.width;
		vpixels=Screen.height;
		xmm=hpixels/xdpi/0.0393701f;
		ymm=vpixels/ydpi/0.0393701f;
		mmdist=xmm/2;

		correction_factor=0.002f*((mmdist-55.0f)/(76.0f-55.0f));

		if (autoCorrectOffset) {
			if(OffsetCenter.instance !=null){
				OffsetCenter.instance.setCorrectionFactor(correction_factor);
			}
		}

		if (start_once>0)start_once--;

		time_since_last_fullscreen+=Time.deltaTime;

		if (time_since_last_fullscreen >8){
			DiveJava.setFullscreen ();
			time_since_last_fullscreen=0;
				
				
		}


		return;
	}

		
	
	public static void setFullscreen(){
		#if UNITY_EDITOR
		
		#elif UNITY_ANDROID
		String answer;
		answer= javadiveplugininstance.Call<string>("setFullscreen");
		#elif UNITY_IPHONE
		
		#endif 	
		
		return;
	}

	public static void init(){
		start_once=0;
		#if UNITY_EDITOR
		
		#elif UNITY_ANDROID
		
		javadivepluginclass = new AndroidJavaClass("com.shoogee.divejava.divejava") ;
		javaunityplayerclass= new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		currentactivity = javaunityplayerclass.GetStatic<AndroidJavaObject>("currentActivity");
		javadiveplugininstance = javadivepluginclass.CallStatic<AndroidJavaObject>("instance");
		object[] args={currentactivity};
		javadiveplugininstance.Call<string>("set_activity",args);

		String answer;
		answer= javadiveplugininstance.Call<string>("setFullscreen");

		// Screen Metrics
		
		metricsClass= new AndroidJavaClass("android.util.DisplayMetrics");
		metricsInstance= new AndroidJavaObject("android.util.DisplayMetrics");
		windowManagerInstance=currentactivity.Call<AndroidJavaObject>("getWindowManager");
		displayInstance=windowManagerInstance.Call<AndroidJavaObject>("getDefaultDisplay");
		
		displayInstance.Call("getMetrics",metricsInstance);
		
		density=metricsInstance.Get<float>("density");
		densitydpi=metricsInstance.Get<int> ("densityDpi");
		vpixels=metricsInstance.Get<int>("heightPixels");
		vpixels=Screen.height;
		hpixels=metricsInstance.Get<int>("widthPixels");
		//hpixels=displayInstance.Call<int>("getWidth");
		hpixels=Screen.width;
		scaledDensity=metricsInstance.Get<float>("scaledDensity");
		xdpi=metricsInstance.Get<float>("xdpi");
		ydpi=metricsInstance.Get<float>("ydpi");
		xmm=hpixels/xdpi/0.0393701f;
		ymm=vpixels/ydpi/0.0393701f;
		
		#elif UNITY_IPHONE
		
		#endif 	
		initiated = true;
	}

}
