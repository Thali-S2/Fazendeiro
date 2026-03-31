using System.Diagnostics.SymbolStore;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using System.Collections;

public class GhostPlayer : MonoBehaviour
{
    private InputAction ghostAction;
    private InputAction naoGhostAction;

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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

    private void Ghost()
    {
        //transform.localScale = new Vector3(0f, 0f, 0f);
        Debug.Log("Ativou Ghost");
        StartCoroutine("TerminaGhost");
    }

    IEnumerator TerminaGhost()
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("Desativou Ghost");
    }

}
