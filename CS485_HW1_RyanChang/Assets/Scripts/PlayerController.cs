using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;
    public AudioSource pickupSFX;

    private Rigidbody rb;
    private int count;
    private AudioSource source;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        pickupSFX = GetComponent<AudioSource>();
        count = 0;
        setCountText();
        winText.text = "";
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        if (other.gameObject.CompareTag("Pickup"))
        {
            pickupSFX.Play();

            other.gameObject.SetActive(false);
            count++;
            setCountText();
        }
    }

    void setCountText()
    {
        countText.text = "Count: " + count.ToString();

        if(count >= 8)
        {
            winText.text = "You Win!";
        }
    }

}