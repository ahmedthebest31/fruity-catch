using UnityEngine;

public class spaner : MonoBehaviour {
	
	float pozlemet = 5.5f;
	public GameObject[] bananas;
	int carNo;
	public float delayTimer = 2f;
	float timer;
	playerController bc;

	void Start () 
	{
		bc = FindObjectOfType<playerController>();
		timer = delayTimer;

	}


	void Update () {

		timer -= Time.deltaTime;
		if (timer <= 0) {
			Vector3 carPos = new Vector3(Random.Range(-pozlemet,pozlemet),transform.position.y,transform.position.z);
			carNo = Random.Range (0,5);
			Instantiate (bananas[carNo], carPos, transform.rotation);
			timer = delayTimer;
		}
		if (bc.level == 2)
		delayTimer = 1.5f;
		else if (bc.level == 3)
			delayTimer = 1f;
		if (bc.level == 4)
			delayTimer = 0.50f;
		if (bc.level == 5)
			delayTimer = 0.25f;
		

	}
}
