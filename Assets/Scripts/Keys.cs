using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keys : MonoBehaviour
{
    public GameObject slider;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.DownArrow)) slider.GetComponent<Slider>().value = slider.GetComponent<Slider>().value -1;
        if (Input.GetKey(KeyCode.UpArrow)) slider.GetComponent<Slider>().value = slider.GetComponent<Slider>().value +1;
    }
}
