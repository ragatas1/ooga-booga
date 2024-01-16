using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteinSpawneScript : MonoBehaviour
{
    public movement spilleren;
    public GameObject stein;
    public BulletScript steinScript;
    void Update()
    {
        if (spilleren.harStein == true)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                lagStein();
                spilleren.harStein = false;
            } 
        }
    }
    void lagStein()
    {
        Instantiate(stein, new Vector3 (transform.position.x, transform.position.y, 0),transform.rotation);
    }
}
