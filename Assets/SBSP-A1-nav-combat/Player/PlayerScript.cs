using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	//public Canvas[] AllCanvas; 
	public GameObject[] AllCanvas; 

	/*
	public Canvas Canvas1_Captain;
	public Canvas Canvas2_Navigator;
	public Canvas Canvas3_Combat;
	public Canvas Canvas4_Manufacturing;
	public Canvas Canvas5_Power;

*/
	private int playerRole;
	public int PlayerRole{
		get {return playerRole;}
		set {
			if (playerRole == value) {
				return;
			} else if (value <= 0 && value <=  4) {
				playerRole = value;
				changeActivePlayerRoleUI (value);
			}
		}
	}

	void Start(){
		roleSetUpINIT ();
		PlayerRole = 0;
		changeActivePlayerRoleUI (0);
	}

	private void roleSetUpINIT (){
		for (int i = 0; i < AllCanvas.Length; i++) {
			//AllCanvas [i].enabled = false;
			AllCanvas [i].SetActive(false);
		}
	}

	private void changeActivePlayerRoleUI(int newRole){
		for (int i = 0; i < AllCanvas.Length; i++) {
			//AllCanvas [i].enabled = false;
			AllCanvas [i].SetActive(false);
		}
		AllCanvas [newRole].SetActive(true);
	}

	public void ChangePlayerRoleSlider(float newRole){
		changeActivePlayerRoleUI ((int)newRole);
	}

}
