using UnityEngine;
using UnityEngine.UI;

public class RadarPlayerPosition : MonoBehaviour {
	//Gameobject for position player
	public GameObject player;

	//Display X, Y, Z On UI
	GameObject playerDisplayX;
	GameObject playerDisplayY;
	GameObject playerDisplayZ;

	//Text for UI
	Text playerPositionTextX;
	Text playerPositionTextY;
	Text playerPositionTextZ;

	//Where each position is stored
	float y;
	float x;
	float z;

	// Use this for initialization
	void Start () 
	{
		playerDisplayX = GameObject.Find ("Radar_playerDisplayX");
		playerDisplayY = GameObject.Find ("Radar_playerDisplayY");
		playerDisplayZ = GameObject.Find ("Radar_playerDisplayZ");
	}
	
	// Update is called once per frame
	void Update () 
	{
		PlayerPosition();
	}

	public void PlayerPosition()
	{
		//Store player position for x, y, z
		x = player.transform.position.x;
		y = player.transform.position.y;
		z = player.transform.position.z;

		//Display position x
		playerPositionTextX = playerDisplayX.GetComponent<Text>();
		playerPositionTextX.text = "X: " + x;

		//Display position y
		playerPositionTextY = playerDisplayY.GetComponent<Text>();
		playerPositionTextY.text = "Y: " + y;

		//Display position z
		playerPositionTextZ = playerDisplayZ.GetComponent<Text>();
		playerPositionTextZ.text = "Z: " + z;


	}
}
