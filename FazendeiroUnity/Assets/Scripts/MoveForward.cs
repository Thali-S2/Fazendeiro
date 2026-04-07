using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private GameObject player;
    private NewPlayerControl playerScript;
    public float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerScript = player.GetComponent<NewPlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerScript.isPaused)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

    }
}
