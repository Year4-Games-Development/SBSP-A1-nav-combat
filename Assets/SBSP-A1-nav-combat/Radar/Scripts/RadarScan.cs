using UnityEngine;
using UnityEngine.UI;


public class RadarScan : MonoBehaviour
{
	GameObject Enemy;
	GameObject TimerDisplay;
	GameObject Asteroid;
<<<<<<< HEAD
	public Image RadarImageToChange;
    Image Asteroidimg;
=======
	public Image EnemyImageToChange;
    public Image AsteroidImageToChange;
>>>>>>> 166ef8efaf03865bbe86b878692c8b5ba9847a6e
    int timerSeconds = 5;
    Text t_display;
        
	void Start() 
	{       
		Enemy = GameObject.Find("Enemy");   
		TimerDisplay = GameObject.Find ("Radar_TimerDisplay");
		Asteroid = GameObject.Find ("Asteroid");
<<<<<<< HEAD
        Asteroidimg = Asteroid.GetComponent<RadarScan>().RadarImageToChange;
    }
=======
     }
>>>>>>> 166ef8efaf03865bbe86b878692c8b5ba9847a6e

	public void ChangeImage(Image UpdateImage)
    {
		if (Enemy.tag == "Enemy" & Asteroid.tag == "Asteroid")
        {
            timerSeconds = 5;
			InvokeRepeating ("RadarChangeImage", 1, 1);
		} 
    }

	public void RadarChangeImage()
	{
		timerSeconds--;
		t_display = TimerDisplay.GetComponent<Text> ();
		t_display.text = timerSeconds.ToString();

		if (timerSeconds < 1) {
			CancelInvoke ("RadarChangeImage");	
<<<<<<< HEAD
			Radar.RegisterRadarObject (Enemy, RadarImageToChange);
            Radar.RegisterRadarObject(Asteroid, Asteroidimg);
        }
	}
}
=======
			Radar.RegisterRadarObject (Enemy, EnemyImageToChange);
            Radar.RegisterRadarObject(Asteroid, AsteroidImageToChange);
        }
	}
}

>>>>>>> 166ef8efaf03865bbe86b878692c8b5ba9847a6e
