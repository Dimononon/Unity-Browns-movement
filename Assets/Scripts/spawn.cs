using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject sphere;
    public int number;
    public float speed;
    public float size;
    
    void Start()
    {
        speed = 1f;
        size = 3;
        number = 25;
        sphere.GetComponent<Transform>().localScale = new Vector3(size, size, size);
        for (int i=0; i<number; i++)
        {
            Instantiate(sphere, new Vector3(Random.Range(-25, 25), Random.Range(-25, 25), Random.Range(-25, 25)), new Quaternion(0, 0, 0, 0));
        }
        
    }

    
}
