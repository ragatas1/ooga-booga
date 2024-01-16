using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinneUtAvDetScript : MonoBehaviour
{
    public Player1SSKScript spiller1;
    public Player2SSKScript spiller2;
    public GameObject LogikkSjef;
    public LogikkScript logikk;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        LogikkSjef = GameObject.FindGameObjectWithTag("Logikk");
        logikk = LogikkSjef.GetComponent<LogikkScript>();
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + 1 * Time.deltaTime;
        if (timer > 5)
        {
            if (spiller1.transform.position.x == -3)
            {
                if (spiller2.transform.position.x == -3)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
                else if (spiller2.transform.position.x == 0)
                {
                    logikk.hvemLeder = 2;
                    SceneManager.LoadScene("BaneForsok");
                }
                else
                {
                    logikk.hvemLeder = 1;
                    SceneManager.LoadScene("BaneForsok");
                }
            }
            else if (spiller1.transform.position.x == 0)
            {
                if (spiller2.transform.position.x == 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
                else if (spiller2.transform.position.x == 3)
                {
                    logikk.hvemLeder = 2;
                    SceneManager.LoadScene("BaneForsok");
                }
                else
                {
                    logikk.hvemLeder = 1;
                    SceneManager.LoadScene("BaneForsok");
                }
            }
            else if (spiller1.transform.position.x == 3)
            {
                if (spiller2.transform.position.x == 3)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
                else if (spiller2.transform.position.x == -3)
                {
                    logikk.hvemLeder = 2;
                    SceneManager.LoadScene("BaneForsok");
                }
                else
                {
                    logikk.hvemLeder = 1;
                    SceneManager.LoadScene("BaneForsok");
                }
            }
            else
            {
                logikk.hvemLeder = 2;
                SceneManager.LoadScene("BaneForsok");
            }
        }
    }
}
