using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class animPop7 : MonoBehaviour {
	Image img;
	bool into=false;
	Text text;
	void Start(){
		img = GetComponent<Image> ();
		text = GetComponentInChildren<Text> ();
	}
	public void playAnim1(){
		if (!into) {
			into = true;
			Color color = img.color;
			color.a = 1f;
			img.color = color;
			text.text="Heart";
		}
		else {
			into = false;
			Color color = img.color;
			color.a = 0f;
			img.color = color;
			text.text="";
		}
	}
	
	
}
