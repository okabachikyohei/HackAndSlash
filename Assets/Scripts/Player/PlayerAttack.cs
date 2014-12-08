﻿using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

	public GameObject target;
	public float attackTimer;
	public float coolDown;
	EnemyHealth enemyHealth;

	 
	void Awake() {
		enemyHealth = target.GetComponent <EnemyHealth> ();
	}
	// Use this for initialization
	void Start () {
		attackTimer = 0;
		coolDown = 2.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (attackTimer > 0)
			attackTimer -= Time.deltaTime;

		if (attackTimer < 0)
			attackTimer = 0;

		if (Input.GetKeyUp (KeyCode.F)) {
			if (attackTimer == 0) {
				Attack();
				attackTimer = coolDown;
			}						
		}
	}

	private void Attack() {
		float distance = Vector3.Distance (target.transform.position, transform.position);

		Vector3 dir = (target.transform.position - transform.position).normalized;
		Debug.Log ("dir = " + dir);
		float direction = Vector3.Dot (dir, transform.forward);

		Debug.Log ("direction = " + direction);
		// direction > 0, in front of player
		if (distance < 2.5f && direction > 0) {
			enemyHealth.AddjustCurrentHealth (-10);	
		}

	}
}
