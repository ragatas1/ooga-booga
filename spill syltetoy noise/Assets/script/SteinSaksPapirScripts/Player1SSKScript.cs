using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1SSKScript : MonoBehaviour
{
    public int hvorHoyt;
    private float timer = 0;

    void Update()
    {
        if (timer < 4)
        {
            transform.position = new Vector3(Input.GetAxisRaw("Horizontal1") * 3, hvorHoyt);
            timer = timer + 1 * Time.deltaTime;
        }
    }
}
