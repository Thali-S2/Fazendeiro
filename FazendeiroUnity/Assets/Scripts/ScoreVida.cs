using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreVida : MonoBehaviour
{
    public static ScoreVida instancee;
    
    public TextMeshProUGUI scoreTextVida;
    public GameObject gameOver;

    int scoreVida=3;

    private void Awake()
    {
        instancee = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreTextVida.text = scoreVida.ToString() + " VIDAS";
    }

    // Update is called once per frame
    public void Vidas()
    {
        if (scoreVida > 0)
        {
            scoreVida -= 1;
            scoreTextVida.text = scoreVida.ToString() + " VIDAS";
        }
        
        
        if (scoreVida <=0)
        {
            scoreTextVida.text = "0";
            gameOver.gameObject.SetActive(true);
        }
    }
}
