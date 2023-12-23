using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnExit : MonoBehaviour {

	public GameObject panelExit;

	public void ExitControl ()
	{
		if (Time.timeScale ==1){
			panelExit.SetActive (true);
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;
			panelExit.SetActive (false);
		}
	}

	public void scene(string scene){
		Application.LoadLevel (scene);
	}

	public void quit (){
		Application.Quit ();
	}
}