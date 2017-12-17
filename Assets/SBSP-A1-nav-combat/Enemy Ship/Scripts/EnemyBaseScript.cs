using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBaseScript : MonoBehaviour {

	private int maxHealth = 100000;
	private int health;
	public int Health{ set { health = value; } get { return health; } }

	Slider healthBar;

	void Start(){
		health = maxHealth;
		healthBar = gameObject.GetComponentInChildren<Slider> ();
		healthBar.value = health/maxHealth * 100;
	}

	public void damageHealth(int dmg2health){
		Health -= dmg2health;
		//Debug.LogError (Health);
		//Debug.LogError("health " + health + " maxHealth "+ maxHealth + " % = " + (float)health/(float)maxHealth * 100f);
		healthBar.value = (float)health/(float)maxHealth * 100f;
		if (Health <= 0){
			destroyTheEnemy ();
		}
	}

	private void destroyTheEnemy(){
		Destroy (gameObject);
	}
}
