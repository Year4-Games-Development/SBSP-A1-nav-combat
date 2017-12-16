using UnityEngine;
using UnityEngine.UI;

public class RadarDistance : MonoBehaviour {
	//player and enemy gameobjects to calculate distance from each other
	public GameObject enemy;
	public GameObject player;

 	//Text display for distance
	GameObject distanceDisplay;
	Text distanceEnemy_Display;

	//Store distance
	float distance_;

	void Start() 
	{       
		distanceDisplay = GameObject.Find ("Radar_DistanceDisplay");
	}

	void Update()
	{
		distanceFromEnemy ();
	}


	public void distanceFromEnemy()
	{
		//Get distance between player and enemy
		distance_ = Vector3.Distance(player.transform.position, enemy.transform.position);

		//Text Display for distance > 1000
		if (distance_ > 1000)
		{
			distanceEnemy_Display = distanceDisplay.GetComponent<Text>();
			distanceEnemy_Display.text = distance_.ToString();
		}

		//Text Display for distance < 500
		if (distance_ < 500) 
		{
			distanceEnemy_Display = distanceDisplay.GetComponent<Text>();
			distanceEnemy_Display.text = "Enemy Nearby!";
		
		}
	}
}
