using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EngineView : MonoBehaviour {


	public Text powerText;
	public Text engineStateText;
	public Slider accSlider;
	public Text velText;

	public Text powerText2;
	public Text engineStateText2;
	public Slider accSlider2;
	public Text velText2;

	public Slider autoSlider;
	public Text autoText;
	public Text autoPowText;

	private EngineController engineCont;


	private void Awake()
	{
		engineCont = GetComponent<EngineController>();
	}

	private void Start()
	{
		accSlider.onValueChanged.AddListener(delegate { engineCont.Accelerate(accSlider); });
		accSlider2.onValueChanged.AddListener(delegate { engineCont.Accelerate(accSlider2); });
		autoSlider.interactable = false;
		autoSlider.onValueChanged.AddListener (delegate {engineCont.EngineAutoAcc(autoSlider);});
	}

	//update text message for the power value
	public void UpdatePower(float power)
	{
		string powerMessage = "Power : " + power;

		//update UI on the screen with the message
		powerText.text = powerMessage;
		powerText2.text = powerMessage;
		autoPowText.text = powerMessage;

	}

	public void UpdateVelocity(float vel)
	{
		int vel1 = Mathf.RoundToInt (vel);
		string velMessage = "Velocity: " + vel1 + " km/sec";
		velText.text = velMessage;
		velText2.text = velMessage;

	}

	/*public void UpdateEngineState(bool engineState)
	{
		string engineStateString;

		if (engineState)
		{
			engineStateString = "ON";
			accSlider.interactable = true;

		}
		else
		{
			engineStateString = "OFF";
			powerText.text = "Power : 0";
			accSlider.value = 0;
			accSlider.interactable = false;
		}

		string engineStateMessage = "Engine : " + engineStateString;

		engineStateText.text = engineStateMessage;
	}*/

	/*public void ToggleButtonEngine(){
		if (toggle.isOn) {
			toggleText.text = "ON";
			engineCont.TurnOnEngine();
		} else {
			toggleText.text = "OFF";
			engineCont.TurnOffEngine();
		}
	}*/

}