using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

	/// <summary>
	/// Player shooting by Jerry Sam.
	/// </summary>

	public string bulDir;

	public float bulletCD;

	public bool isShooting;

	public Rigidbody2D bullet;

	private float _maxSpd;
	private float _shotTimer;

	private Transform _bulDir;
	[SerializeField]
	private Transform _bulOrigin;
	private Rigidbody2D _bulInstance;

	private GunController gun;


	void Awake () {
		_maxSpd = 2;
		bulDir = "right";
	}
	
	void Update () {
		if (Input.GetButtonDown("Fire1")) { 
			Shoot ();
		}
		ChangeAimDir();
	}

	private void Shoot(){
	_shotTimer -= Time.deltaTime;
		if (_shotTimer <= 0) {
			_shotTimer = bulletCD;
			_bulInstance = Instantiate (bullet, _bulOrigin.transform.position, Quaternion.Euler (new Vector3 (0, 0, 1))) as Rigidbody2D;  
			if (bulDir == "right") {
				_bulInstance.velocity = transform.right * _maxSpd;

			} else if (bulDir == "left") {
				_bulInstance.velocity = -transform.right * _maxSpd;  
			} else {
				_bulInstance.velocity = transform.up * _maxSpd;  
			}
			Physics2D.IgnoreCollision (_bulInstance.GetComponent<Collider2D> (), GetComponent<Collider2D> ()); 
		} else {
			_shotTimer = 0;
		}
	}

	private void ChangeAimDir(){
		if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
			_bulOrigin = this.gameObject.transform.GetChild (2);
			bulDir = "up";
		}
		else if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
			_bulOrigin = this.gameObject.transform.GetChild (1);
			bulDir = "left";
		}
		else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
			_bulOrigin = this.gameObject.transform.GetChild (0);
			bulDir = "right";
		}
	}
}
