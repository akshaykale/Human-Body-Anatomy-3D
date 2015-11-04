using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;

public class que_script : MonoBehaviour {

	public InputField i_causes;
	public InputField i_medications;
	public InputField i_allergies;
	public Slider sl_pain;
	public Slider sl_duration;

	public static int pain;
	public static int duration;
	public static String causes;
	public static String medication;
	public static String allergies;

	void Start () {
	
	}
	
	void Update () {
	
	}

	public void painData(float p){
		pain = (int)p;
	}
	public void durationData(float d){
		duration = (int)d;
	}

	public void clickedSendButton(){

		causes = i_causes.text;
		medication = i_medications.text;
		allergies = i_allergies.text;

		print ("hi");
		String fileName = "dataset_ques.txt";
		
		StreamWriter sr = File.CreateText(fileName);
		String data = pain + "-" + duration
			+ "-" + causes + "-" + medication + "-" + allergies;// + "-" + habbits_smoking + "-" + habbits_drinking + "-" + habbits_food + "-" + habbits_siting;
		sr.WriteLine (data);
		sr.Close();
		
		//Application.loadedLevel ("mail");
		
	}



}
