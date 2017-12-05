using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(EngineView))]
public class EngineController : MonoBehaviour {

	private EngineView engView;
	private Engine engine;
	public string axis;
	private Rigidbody rb;
	private float timePassed = 6;

	float mag;

	// Use this for initialization
	void Start () {
		rb = GetComponentInParent<Rigidbody> ();
		engine = new Engine();
		engView = GetComponent<EngineView>();
		engView.UpdatePower(engine.GetPower());
		//engView.UpdateEngineState(engine.GetIsOn());
	}

	// Update is called once per frame
	void FixedUpdate () {

		mag = rb.velocity.magnitude;
		engView.UpdateVelocity (mag);



		if(axis == "Forward")
		{
			if (timePassed < 3) {
				rb.AddForce (engine.GetPower () * transform.forward);
				timePassed += Time.deltaTime;
			}
		}
		if (axis == "Backward")
		{

			if ( timePassed < 3)
			{
				rb.AddForce (-engine.GetPower () * transform.forward);
				timePassed += Time.deltaTime;
			}
		}
	}

	//TrunOnEngine method
	//sets power of the engine to zero and isOn to true
	/*public void TurnOnEngine()
	{
		if (!engine.GetIsOn())
		{
			engine.SetPower(0);
			engine.SetIsOn(true);
			engView.UpdateEngineState(engine.GetIsOn());

		}
		else
		{
			Debug.Log("Cannot turn on engine, engine is ON");
		}

	}

	//TrunOffEngine method
	//sets power of the engine to zero and isOn to true
	public void TurnOffEngine()
	{
		if (engine.GetIsOn())
		{
			engine.SetPower(0);
			engine.SetIsOn(false);
			engView.UpdateEngineState(engine.GetIsOn());
		}
		else
		{
			Debug.Log("Cannot turn off engine, engine is OFF");
		}
	}*/

	public void Accelerate(Slider slider)
	{
			engine.SetPower((slider.value));
			engView.UpdatePower(engine.GetPower());


	}

	public void OneTimeThrust(Slider slider)
	{

		engine.SetPower((slider.value));
		engView.UpdatePower(engine.GetPower());
		timePassed = 0;


	}
}