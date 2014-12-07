using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int maxHealth = 100;
	public int curHealth;
	public Slider healthSlider;

	bool damaged;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (damaged) {
				

		}
	
	}

	public void AddjustCurrentHealth(int adj) {
		curHealth += adj;

		if (curHealth < 0)
			curHealth = 0;

		if (curHealth > maxHealth)
			curHealth = maxHealth;

		if (maxHealth < 1)
			maxHealth = 1;

		healthSlider.value = curHealth;

	}
}
