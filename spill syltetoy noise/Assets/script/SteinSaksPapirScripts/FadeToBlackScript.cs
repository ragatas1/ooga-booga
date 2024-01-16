using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeToBlackScript : MonoBehaviour
{
    public float timer = 0;
    public SpriteRenderer minSprite;
    public float minfarge = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + 1 * Time.deltaTime;
        if (timer > 1.3)
        {
            minSprite.color = new Color(0, 0, 0, minfarge);
            minfarge = minfarge + 1 * Time.deltaTime;
        }
        if (timer > 4) 
        {
            minSprite.color = new Color(0, 0, 0, 0);
        }

    }
}
