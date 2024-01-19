using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    GameObject LogikkSjef;
    public LogikkScript logikk;
    public SpriteRenderer player1Check;
    public SpriteRenderer player2Check;
    Animator animator;
    private void Start()
    {
        LogikkSjef = GameObject.FindGameObjectWithTag("Logikk");
        logikk = LogikkSjef.GetComponent<LogikkScript>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2"))
        {
            animator.SetTrigger("gjorDet");
        }
        if (Input.GetButton("Jump1"))
        {
            player1Check.enabled = true;
            if (Input.GetButton("Jump2"))
            {
                logikk.hvemLeder = Random.Range(1, 3);
                SceneManager.LoadScene("BaneForsok");
            }
        }
        else
        {
            player1Check.enabled=false;
        }
        if (Input.GetButton("Jump2"))
        {
            player2Check.enabled = true;
        }
        else
        {
            player2Check.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            logikk.hvemLeder = 2;
            SceneManager.LoadScene("BaneForsok");
        }
    }
}
