using UnityEngine;
using TMPro;

public class ScoreVida : MonoBehaviour
{
    public static ScoreVida instancee;
    
    public TextMeshProUGUI scoreTextVida;

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
        scoreVida -= 1;
        scoreTextVida.text = scoreVida.ToString() + " VIDAS";

    }
}
