using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;


public class __UI_script : MonoBehaviour {

	public GameObject gender_panel;
	public GameObject age_panel;
	public GameObject habbits_panel;
	public GameObject other_panel;

	//Images
	public GameObject i1,i2,i3,i4;

	//Buttons
	public Button bt_age_child,bt_age_man,bt_age_old,bt_age_young;

	//Text
	public Text txt_age;
	public Text txt_height,txt_weight,txt_bmi;

	//Toggle
	public Toggle tg_hab_smoking,tg_hab_drinking,tg_hab_food,tg_hab_sit;

	//Data
	public static int gender = 1;
	public static float age = 0;
	public static int habbits_smoking = 0; 
	public static int habbits_drinking = 0;
	public static int habbits_siting = 0; 
	public static int habbits_food = 0;
	public static float height = 50.0f;
	public static float weight = 10.0f;
	public static String name = "name";

	float bmi_;

	void Awake(){
		DontDestroyOnLoad(this);
	}

	void start(){
		bt_age_old.interactable = false;
		bt_age_child.interactable = false;bt_age_man.interactable = false;bt_age_young.interactable = false;
	}

	void Update(){
		
	}

	public void ageData(){
		gender_panel.SetActive (false);
		habbits_panel.SetActive (false);
		other_panel.SetActive (false);
		age_panel.SetActive (true);
	}

	public void genderData(){
		gender_panel.SetActive (true);
		habbits_panel.SetActive (false);
		other_panel.SetActive (false);
		age_panel.SetActive (false);
	}

	public void habbitsData(){
		gender_panel.SetActive (false);
		habbits_panel.SetActive (true);
		other_panel.SetActive (false);
		age_panel.SetActive (false);
	}

	public void otherData(){
		gender_panel.SetActive (false);
		habbits_panel.SetActive (false);
		other_panel.SetActive (true);
		age_panel.SetActive (false);
	}

	public void maleClick(){
		gender = 1;
	}
	public void femaleClick(){
		gender = 0;
	}

	public void ageChange(float a){
		age = a;
		txt_age.text = "Age: " + (int)a;
		if (a > 0 && a < 12) {
			bt_age_child.interactable = true;
			bt_age_young.interactable = false;bt_age_man.interactable = false;bt_age_old.interactable = false;
		}else if(a >=12 && a <26){
			bt_age_young.interactable = true;
			bt_age_child.interactable = false;bt_age_man.interactable = false;bt_age_old.interactable = false;
		}else if(a >=26 && a <60){
			bt_age_man.interactable = true;
			bt_age_child.interactable = false;bt_age_young.interactable = false;bt_age_old.interactable = false;
		}else if(a >=61 && a <200){
			bt_age_old.interactable = true;
			bt_age_child.interactable = false;bt_age_man.interactable = false;bt_age_young.interactable = false;
		}
	}

	public void habbitSmokingClicked(){
		habbits_smoking = 1;
	}
	public void habbitDrinkingClicked(){
		habbits_drinking = 1;
	}
	public void habbitFoodClicked(){
		habbits_food = 1;
	}
	public void habbitSitClicked(){
		habbits_siting = 1;
	}


	public void heightData(float h){
		txt_height.text = "Height(cm): " + (int)h;
		height = h;
		bmi_ = weight / (h * h * 0.01f * 0.01f);
		if (bmi_ <= 18.5f) {
			txt_bmi.text = "BMI -\n UnderWeight\n" + bmi_;
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
	public void weightData(float w){
		txt_weight.text = "Weight(Kg): " + (int)w;
		weight = w;
		bmi_ = w / (height * height * 0.01f * 0.01f);
		if (bmi_ <= 18.5f) {
			txt_bmi.text = "BMI -\n UnderWeight\n" + bmi_;
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


	public void clickedGObutton(){
		print ("hi");
		/*String fileName = "dataset.txt";

		StreamWriter sr = File.CreateText(fileName);
		String data = name + "-" + (gender == 1 ? "male" : "female")
			+ "-" + age + "-" + height + "-" + weight + "-" + habbits_smoking + "-" + habbits_drinking + "-" + habbits_food + "-" + habbits_siting;
				sr.WriteLine (data);
		sr.Close();
*/
		Application.LoadLevel ("main_body");

	}
}
