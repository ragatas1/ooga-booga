using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LogikkScript : MonoBehaviour
{
    public TextMeshProUGUI score1Text;
    public TextMeshProUGUI score2Text;
    public Canvas uI;
    public TextMeshProUGUI timer;
    public AudioSource BonkSoundEffect;
    public int spiller1Score;
    public int spiller2Score;
    public int hvemLeder = 0;
    public float spiller1Tid;
    public float spiller2Tid;
    public int hvemHarStein = 0;
    public float tidPaAKaste;
    public int hvorMyeForAVinne;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        DontDestroyOnLoad(uI);
        BonkSoundEffect.time = 0.25f;
    }

    public void leggTilScore1()
    {
        BonkSoundEffect.Play();

        spiller1Score = spiller1Score+1;
        score1Text.text = spiller1Score.ToString();
    }
    public void leggTilScore2()
    {
        BonkSoundEffect.Play();
        spiller2Score = spiller2Score + 1;
        score2Text.text = spiller2Score.ToString();
    }
    private void Update()
    {
        if (spiller1Score < spiller2Score)
        {
            hvemLeder = 2;
        }
        else if (spiller1Score > spiller2Score)
        {
            hvemLeder = 1;
        }
        if (hvemHarStein == 1)
        {
            spiller1Tid = Mathf.Round(spiller1Tid * 1f) * 1f;
            timer.text = spiller1Tid.ToString();
        }
        if (hvemHarStein == 2)
        {
            spiller2Tid = Mathf.Round(spiller2Tid * 1f) * 1f;
            timer.text = spiller2Tid.ToString();
        }
        if (spiller1Score >= hvorMyeForAVinne)
        {
            SceneManager.LoadScene("Mordi Vant");
            spiller1Score = 0;
            spiller2Score = 0;
            Destroy(uI);
        }
        if (spiller2Score >= hvorMyeForAVinne)
        {
            SceneManager.LoadScene("Fardi Vant");
            spiller1Score = 0;
            spiller2Score = 0;
            Destroy(uI);
        }
        if (Input.GetButton("Lukk"))
        {
            Destroy(uI);
            SceneManager.LoadScene("startscene");
            Destroy(gameObject);
        }
    }
}
