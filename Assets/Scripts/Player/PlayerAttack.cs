using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

	public GameObject target;
	EnemyHealth enemyHealth;
	 
	void Awake() {
		enemyHealth = target.GetComponent <EnemyHealth> ();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.F)) {
			Attack();		
		}
	}

	private void Attack() {
		enemyHealth.AddjustCurrentHealth (-10);
	}
}
