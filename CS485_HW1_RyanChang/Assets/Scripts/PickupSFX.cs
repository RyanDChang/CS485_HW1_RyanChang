using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSFX : MonoBehaviour {

    public GameObject coin;
    public AudioClip pickupSFX;

    private float throwSpeed = 50;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

	// Use this for initialization
	void Awake ()
    {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButton("Fire1"))
        {
            source.PlayOneShot(pickupSFX, 1F);
            GameObject pickupCoin = Instantiate(coin, transform.position, transform.rotation) as GameObject;
            //pickupCoin.rigidbody.AddRelativeForce(new Vector3(0, throwSpeed, 0));
        }
	}
}
