using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour {
	private float timeToArm = 0f;
	private float timeToDetonate;
	private float timeToArmLeft;
	private float explosionRange;
	private int baseDamage;
	private float startTime = 0f;

	// todo range of explosion - collision dettection
	// inflict damage method
	// timeToArm

	public void setTimeToArm(float tta){timeToArm = tta;}
	public void setTimeToDetonate(float ttd){timeToDetonate = ttd;}
	public void setExplosionRange(float er){explosionRange = er;}
	public void setBaseDamage(int dmg){baseDamage = dmg;}

	void Start(){
		Invoke("Detonate", timeToDetonate);
	}

	private int counter = 0;
	private float deltaTime = 0f;



	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.CompareTag ("Enemy")) {
			EnemyBaseScript enemy = collision.gameObject.GetComponent<EnemyBaseScript> ();
			if (enemy != null) {
				enemy.damageHealth (baseDamage);
			}
		}
		Detonate ();
	}

	public void Detonate(){
		Debug.Log ("BOOM");
		Destroy (gameObject);
	}
}
