using UnityEngine;
using TMPro;
using Unity.VisualScripting;
public class Temporizador : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    public float tempoDecorrido;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempoDecorrido += Time.deltaTime;
        int minutes = Mathf.FloorToInt(tempoDecorrido / 60);
        int seconds = Mathf.FloorToInt(tempoDecorrido % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
