using UnityEngine;
using UnityEngine.Networking;

public class BroadsideCannon : MonoBehaviour {

	public CannonBall cannonBallPrefab;
	//public GameObject cannonBallPrefab;
	private CannonsController cannonsController;

	void Start(){
		cannonsController = FindObjectOfType<CannonsController> ();
	}

	//[Command]
	public void CmdFireCannon(){
		CannonBall newBall = Instantiate (cannonBallPrefab, transform.position, transform.rotation);
		newBall.setTimeToArm (30f);
		newBall.setTimeToDetonate (cannonsController.CannonBallDistance);
		newBall.setBaseDamage (cannonsController.CannonBallDamage);
		Rigidbody rigidbody;
		rigidbody = newBall.GetComponent<Rigidbody>();
		rigidbody.AddForce(transform.up * cannonsController.CannonThrustForce * cannonsController.CannonsThrustMaxForce);
		//NetworkServer.Spawn (newBall);
	}
}
