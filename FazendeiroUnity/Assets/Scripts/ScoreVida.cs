using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.InputSystem;

public class ScoreVida : MonoBehaviour
{
    public static ScoreVida instancee;
    public TextMeshProUGUI scoreTextVida;
    [SerializeField] private string nomeGameOver; 
    public GameObject vidaBotton;
    private InputAction vidaBottonAction;

    int scoreVida=3;

    private void Awake()
    {
        instancee = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreTextVida.text = scoreVida.ToString();
    }
    void Update()
    {
        if(vidaBottonAction.WasPressedThisFrame())
        {
            VidaBotton();
        }
    }

    // Update is called once per frame

    public void Vidas()
    {
        var playerScript = GameObject.Find("Player").GetComponentInChildren<GhostPlayer>();
        if (scoreVida > 0)
        {
            if (!playerScript.ghosttt)
            {
                scoreVida -= 1;
                scoreTextVida.text = scoreVida.ToString();
            }
       
        }
        
        
        if (scoreVida <=0)
        {
            scoreTextVida.text = "0";
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene(nomeGameOver);
    }
    public void VidaBotton()
    {
        scoreVida += 1;
        scoreTextVida.text = scoreVida.ToString();
        vidaBotton.gameObject.SetActive(false);
        
    }
}
