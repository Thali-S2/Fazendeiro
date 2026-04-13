using UnityEngine;

public class ColisaoPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Animais"))
        {
            ScoreVida.instancee.Vidas();
            Destroy(other.gameObject);
        }
        
    }
}
