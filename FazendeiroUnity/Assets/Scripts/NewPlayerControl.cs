using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class NewPlayerControl : MonoBehaviour
{
    public float speed = 20f;
    public float xRange = 15f;
    public GameObject projectilePrefab;
    //float horizontalInput;
    public InputActionAsset InputActions;
    private InputAction moveAction;
    private InputAction fireAction;
    private InputAction pauseAction;
    private InputAction naopauseAction;
    private float vida = 3;
    private InputAction menuAction;
    public GameObject menuPause;
    public bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = moveAction.ReadValue<Vector2>().x;
        //float horizontalInput = Input.GetAxis("Horizontal");
        // movimenta o player para esquerda e direita a partir da entrada do usu�rio
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        // mant�m o player dentro dos limites do jogo (eixo x)
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.y);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.y);
        }
        if (fireAction.WasPressedThisFrame())
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
         if (pauseAction.WasPressedThisFrame())
        {
            Pause();
        }
        if (naopauseAction.WasPressedThisFrame())
        {
            NaoPause();
        }
        if (menuAction.WasPressedThisFrame())
        {
            AbrirMenu();
        }
        // dispara comida ao pressionar barra de espa�o
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }*/
        
    }

    /*public void MoveEvent(InputAction.CallbackContext context)
    {
        horizontalInput = context.ReadValue<Vector2>().x;
    }

    public void FireEvent(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        
    }*/

    private void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();
    }
    private void OnDisable()
    {
        InputActions.FindActionMap("Player").Disable();
    }
    private void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        fireAction = InputSystem.actions.FindAction("Jump");
        pauseAction = InputSystem.actions.FindAction("Pause");
        naopauseAction = InputSystem.actions.FindAction("NaoPause");
        menuAction = InputSystem.actions.FindAction("AbrirMenu");
    }
    private void Pause()
    {
        InputActions.FindActionMap("Player").Disable(); // disativa o player
        InputActions.FindActionMap("UI").Enable(); // ativa o UI
        menuPause.gameObject.SetActive(true);
        isPaused=true;

    }
    private void NaoPause()
    {
        InputActions.FindActionMap("UI").Disable(); // disativa o UI
        InputActions.FindActionMap("Player").Enable(); // ativa o Player
        menuPause.gameObject.SetActive(false);
        isPaused=false;

    }

    private void AbrirMenu()
    {
        //SceneManager.LoadScene("Menu");
    }
}