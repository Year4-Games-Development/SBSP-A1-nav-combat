using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	public Canvas Canvas1_Captain;
	public Canvas Canvas2_Engineer;
	public Canvas Canvas3_Combat;
	private int playerRole;
	public int PlayerRole{
		get {return playerRole;}
		set {
			if (playerRole == value) {
				return;
			} else if (value <= 1 && value <=  3) {
				playerRole = value;
				changeActivePlayerRoleUI (value);
			}
		}
	}

	void Start(){
		PlayerRole = 1;
	}

	private void changeActivePlayerRoleUI(int newRole){
		if (newRole == 1) {
			if (Canvas1_Captain.enabled == false) {
				Canvas1_Captain.enabled = true;
			}
			if (Canvas2_Engineer.enabled == true) {
				Canvas2_Engineer.enabled = false;
			}
			if (Canvas3_Combat.enabled == true) {
				Canvas3_Combat.enabled = false;
			}
		} else if (newRole == 2) {
			if (Canvas1_Captain.enabled == true) {
				Canvas1_Captain.enabled = false;
			}
			if (Canvas2_Engineer.enabled == false) {
				Canvas2_Engineer.enabled = true;
			}
			if (Canvas3_Combat.enabled == true) {
				Canvas3_Combat.enabled = false;
			}
		} else if (newRole == 3) {
			if (Canvas1_Captain.enabled == true) {
				Canvas1_Captain.enabled = false;
			}
			if (Canvas2_Engineer.enabled == true) {
				Canvas2_Engineer.enabled = false;
			}
			if (Canvas3_Combat.enabled == false) {
				Canvas3_Combat.enabled = true;
			}
		}
			
	}

	public void ChangePlayerRoleSlider(float newRole){
		changeActivePlayerRoleUI ((int)newRole);
	}

}
