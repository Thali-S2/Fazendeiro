using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private GameObject player;
    private NewPlayerControl playerScript;
    public float speed = 0f;
    private Temporizador scriptTempo;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerScript = player.GetComponent<NewPlayerControl>();

        GameObject objetoDoTempo = GameObject.Find("Temporizadorr"); 
        scriptTempo = objetoDoTempo.GetComponent<Temporizador>();
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = 10f + (scriptTempo.tempoDecorrido/4);

        if (!playerScript.isPaused)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

    }
}
