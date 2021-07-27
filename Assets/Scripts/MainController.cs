using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour
{
    public GameObject startbutton, numberbutton, speedbutton, sizebutton, playbutton, stopbutton, delbutton, number_text, speed_text, size_text, 
        toggle_lead, toggle_size, toggle_van, slider_number, slider_speed, slider_size, slider_sp;
    public GameObject maincamera, sphere, back_gr, destroyer;
    public float speed, size, sizedef;
    public int number;
    public Material sphere_mat, blue_mat;
    

    public void ExitButton()
    {
        Application.Quit();
    }
    public void StartButton()
    {
        startbutton.SetActive(false);
        playbutton.SetActive(true);
        stopbutton.SetActive(true);
        Activator(true);
    }   
    public void PlayButton()
    {
        StartCoroutine(delay());     
    }
    public void StopButton()
    {
        destroyer.SetActive(true);
        Activator(true);
    }
    public void DelButton()
    {
        numberbutton.GetComponent<InputField>().text = null;
        speedbutton.GetComponent<InputField>().text = null;
        sizebutton.GetComponent<InputField>().text = null;
    }
    IEnumerator delay()
    {
        destroyer.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        destroyer.SetActive(false);
        if (numberbutton.GetComponent<InputField>().text != "" && speedbutton.GetComponent<InputField>().text != "" && sizebutton.GetComponent<InputField>().text != "")
        {

            maincamera.GetComponent<FreeCam>().enabled = true;
            back_gr.GetComponent<Image>().color = new Color(85, 161, 229, 0);
            number = Convert.ToInt32(number_text.GetComponent<Text>().text);
            speed = (float)Convert.ToDecimal(speed_text.GetComponent<Text>().text);
            size = (float)Convert.ToDecimal(size_text.GetComponent<Text>().text);
            slider_sp.GetComponent<Slider>().value = speed;
            Activator(false);
            sphere.GetComponent<Sphere>().accel = speed;
            sphere.GetComponent<Transform>().localScale = new Vector3(size, size, size);
            sphere.GetComponent<Sphere>().Startsphere();
            for (int i = 0; i < number; i++)
            {
                Instantiate(sphere, new Vector3(UnityEngine.Random.Range(-20, 20), UnityEngine.Random.Range(-20, 20), UnityEngine.Random.Range(-20, 20)), new Quaternion(0, 0, 0, 0));
                if (toggle_van.GetComponent<Toggle>().isOn)
                {
                    sizedef = size * (1 + UnityEngine.Random.Range(-0.5f, 0.5f));
                    sphere.GetComponent<Transform>().localScale = new Vector3(sizedef, sizedef, sizedef);
                } 
            }
            
            if (toggle_lead.GetComponent<Toggle>().isOn)
            {
                if (toggle_size.GetComponent<Toggle>().isOn) sphere.GetComponent<Transform>().localScale = new Vector3(size * 3, size * 3, size * 3);
                sphere.GetComponent<MeshRenderer>().material = blue_mat;
                //sphere.GetComponent<Sphere>().accel = 0;
                Instantiate(sphere, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
                if (toggle_size.GetComponent<Toggle>().isOn) sphere.GetComponent<Transform>().localScale = new Vector3(size / 3, size / 3, size / 3);
                sphere.GetComponent<MeshRenderer>().material = sphere_mat;
                //sphere.GetComponent<Sphere>().accel = speed;
            }  
        }
    }
    public void Activator(bool x)
    {
        numberbutton.SetActive(x);
        speedbutton.SetActive(x);
        sizebutton.SetActive(x);
        delbutton.SetActive(x);
        toggle_lead.SetActive(x);
        toggle_size.SetActive(x);
        toggle_van.SetActive(x);
        slider_number.SetActive(x);
        slider_size.SetActive(x);
        slider_speed.SetActive(x);
        slider_sp.SetActive(!x);
    }
    public void Slider1()
    {
        switch (slider_number.GetComponent<Slider>().value)
        {
            case 1:
                number = 1;
                break;
            case 2:
                number = 2;
                break;
            case 3:
                number = 3;
                break;
            case 4:
                number = 5;
                break;
            case 5:
                number = 10;
                break;
            case 6:
                number = 20;
                break;
            case 7:
                number = 50;
                break;
            case 8:
                number = 100;
                break;
            case 9:
                number = 500;
                break;
            case 10:
                number = 1000;
                break;
        }
        //number = Convert.ToInt32(slider_number.GetComponent<Slider>().value);
        if (number != 0) numberbutton.GetComponent<InputField>().text = Convert.ToString(number);
    }
    public void Slider2()
    {
        switch (slider_speed.GetComponent<Slider>().value)
        {
            case 1:
                speed = 1;
                break;
            case 2:
                speed = 2;
                break;
            case 3:
                speed = 3;
                break;
            case 4:
                speed = 5;
                break;
            case 5:
                speed = 10;
                break;
            case 6:
                speed = 20;
                break;
            case 7:
                speed = 30;
                break;
            case 8:
                speed = 50;
                break;
            case 9:
                speed = 70;
                break;
            case 10:
                speed = 100;
                break;
        }
        //speed = slider_speed.GetComponent<Slider>().value;
        if (speed != 0) speedbutton.GetComponent<InputField>().text = Convert.ToString(speed);
    }
    public void Slider3()
    {
        size = slider_size.GetComponent<Slider>().value;
        if (size != 0) sizebutton.GetComponent<InputField>().text = Convert.ToString(size);
    }
    
}
