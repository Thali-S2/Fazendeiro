using System.Diagnostics.SymbolStore;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using System.Collections;

public class GhostPlayer : MonoBehaviour
{
    private bool ghosttt = false;
    private bool endTime = true;
    private Renderer playerRender;
    private InputAction ghostAction;
    public InputActionAsset InputActions;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRender = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ghostAction.WasPressedThisFrame())
        {
            Ghost();
        }

    }

    private void Awake()
    {
        ghostAction = InputSystem.actions.FindAction("Ghost");
    }

    private void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();
    }
    private void OnDisable()
    {
        InputActions.FindActionMap("Player").Disable();
    }

    private void Ghost()
    {
        if (!ghosttt)
        {
            playerRender.enabled=false;
            ghosttt=true;
            StartCoroutine(TerminaGhost());
        } else
        {
            playerRender.enabled=true;
            ghosttt=false;
            StartCoroutine(ComecaGhost());
        }

        //Debug.Log("Ativou Ghost");
    }

    IEnumerator TerminaGhost()
    {
        yield return new WaitForSeconds(2f);
        if (ghosttt)
        {
            Ghost();
        }
    }
    IEnumerator ComecaGhost()
    {
        endTime = false;
        yield return new WaitForSeconds(2f);
        endTime = true;

    }

}
