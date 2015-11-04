using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bmi : MonoBehaviour {

	float w,h,bmi_;

	public GameObject i1,i2,i3,i4;
	public Text txt_bmi;

	void Awake(){

		w = __UI_script.weight;
		h = __UI_script.height;
		h = h * 0.01f;
		bmi_ = w / (h * h);

		txt_bmi.text = "\n" + bmi_; 
		if (bmi_ <= 18.5f) {
			txt_bmi.text = "UnderWeight\n" + bmi_;
			i1.SetActive(true);i2.SetActive(false);i3.SetActive(false);i4.SetActive(false);
		} else if (bmi_ > 18.5f && bmi_ <= 24.9f) {
			txt_bmi.text = "NormalWeight\n" + bmi_;
			i1.SetActive(false);i2.SetActive(true);i3.SetActive(false);i4.SetActive(false);
		} else if (bmi_ >= 25f && bmi_ <= 30f) {
			txt_bmi.text = "OverWeight\n" + bmi_;
			i1.SetActive(false);i2.SetActive(false);i3.SetActive(true);i4.SetActive(false);
		} else {
			txt_bmi.text = "Obes\n" + bmi_;
			i1.SetActive(false);i2.SetActive(false);i3.SetActive(false);i4.SetActive(true);
		}
	}

	void Start () {
	
	}

	void Update () {
	
	}

	public void hei(float h){

	}
	public void wei(float w){
		
	}
}
