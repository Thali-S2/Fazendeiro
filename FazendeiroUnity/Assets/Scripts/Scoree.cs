using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scoree : MonoBehaviour
{
    public static Scoree instance;
    
    public TextMeshProUGUI scoreText;

    int score=0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = score.ToString() + " PONTOS";
    }

    // Update is called once per frame
    public void AddPontos()
    {
        score += 1;
        scoreText.text = score.ToString() + " PONTOS";

    }
}
