using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sphere : MonoBehaviour
{
    public Vector3 direction;
    public float accel;
    public Rigidbody rb;
    public GameObject Empty, slider;
    
    public void Startsphere()
    {
        accel = Empty.GetComponent<MainController>().speed;
        direction = new Vector3(Random.Range(-25, 25), Random.Range(-25, 25), Random.Range(-25, 25));
        rb.AddForce(direction.normalized * accel, ForceMode.VelocityChange);
    }
    private void Start()
    {
        direction = new Vector3(Random.Range(-25, 25), Random.Range(-25, 25), Random.Range(-25, 25));
        rb.AddForce(direction.normalized * accel, ForceMode.VelocityChange);
        //slider.GetComponent<Slider>().value = 1;
    }
    public void FixedUpdate()
    {
        if (rb.velocity != new Vector3(0, 0, 0)) direction = rb.velocity;
        accel = slider.GetComponent<Slider>().value;
        rb.constraints = RigidbodyConstraints.FreezePosition;
        rb.constraints = RigidbodyConstraints.None;
        rb.AddForce(direction.normalized * accel, ForceMode.VelocityChange);
   
    }
    

}
