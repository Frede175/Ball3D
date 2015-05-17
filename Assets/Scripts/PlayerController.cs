using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float normalplayerSpeed = 20F;
	public float playerSpeed;
	public float timeLeft;

	private bool countDownActive = false;
	private int playerSpeedEffectTime;
	private Rigidbody rb;

	void Awake()
	{
		playerSpeed = normalplayerSpeed;
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate () {
		if (GameManager.instance.doingSetUp)
			return;
		float horizontal = Input.GetAxis("Horizontal") * playerSpeed;
		float vertical = Input.GetAxis("Vertical") * playerSpeed;

		Vector3 movement = new Vector3(horizontal, 0f, vertical);

		rb.AddForce(movement);


		//check countdown
		if (countDownActive)
		{
			if (timeLeft <= 0)
			{
				CancelInvoke();
				countDownActive = false ;
				timeLeft = 0f;
				playerSpeed = normalplayerSpeed;
			}
		}

	}
	/* -------- Speed Effect! --------*/
	public void playerEffectSpeed(float speed, float time)
	{
		countDownActive = true;
		timeLeft = time;
		playerSpeed = speed;
		InvokeRepeating("countDown",1.0f, 1.0f); 
	}

	float countDown()
	{
		return timeLeft--; 
	}
}
