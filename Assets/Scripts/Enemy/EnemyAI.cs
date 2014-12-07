using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public Transform target;
	public int moveSpeed;
	public int rotationSpeed;

	private Transform myTransfrom;

	void Awake () {
		myTransfrom = transform;
	}

	// Use this for initialization
	void Start () {
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		target = player.transform;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawLine (target.position, myTransfrom.position , Color.yellow);

		//Look at target
		myTransfrom.rotation = Quaternion.Slerp (myTransfrom.rotation, Quaternion.LookRotation(target.position - myTransfrom.position), rotationSpeed * Time.deltaTime);

		//Move towards target
		myTransfrom.position += myTransfrom.forward * moveSpeed * Time.deltaTime;
	}
}
