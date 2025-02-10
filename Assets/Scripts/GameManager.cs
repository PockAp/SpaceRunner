using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int rings;
    public int lives = 5;
    [SerializeField] private GameObject[] ringslist;
    public GameObject winpanel;
    public GameObject losepanel;
    private int currentlvl;
    public AudioSource ringsource;
    public AudioSource livesource;
    public AudioSource shootsource;
    [SerializeField] private TextMeshProUGUI lvltext;
    [SerializeField] private TextMeshProUGUI livestext;
    [SerializeField] private TextMeshProUGUI ringstext;


    void Start()
    {
        winpanel.SetActive(false);
        currentlvl = SceneManager.GetActiveScene().buildIndex;
        ringslist = GameObject.FindGameObjectsWithTag("Ring");
        rings = ringslist.Length;
        losepanel.SetActive(false);
        UpdateLVLText();
        UpdateUIRings();
    }

    void Update()
    {
        if(CheckRings())
        {
            winpanel.SetActive(true);
        }

        if(lives <= 0)
        {
            Lose();
        }
    }

    public void UpdateUILives()
    {
        livestext.text = lives.ToString();
    }
    public void UpdateUIRings()
    {
        ringstext.text = "Rings left :" + rings.ToString();
    }

    public void UpdateLVLText()
    {
        lvltext.text = "LVL : " + currentlvl.ToString();
    }

    public void RestartLVL()
    {
        SceneManager.LoadScene(currentlvl);

    }

    public void ShootPlay()
    {
        shootsource.Play();
    }
    public void HealPlay()
    {
        livesource.Play();
    }
    public void Lose()
    {
        losepanel.SetActive(true);
    }

    public void PlayRingCollect()
    {
        ringsource.Play();
    }
    public void NextLevel()
    {
        currentlvl++;
        SceneManager.LoadScene(currentlvl);
    }

    public bool CheckRings()
    {
        GameObject[] ringss = GameObject.FindGameObjectsWithTag("Ring");
        return ringss.Length == 0;
    }

    public void Lemon2()
    {
        SceneManager.LoadScene(0);
    }
}
