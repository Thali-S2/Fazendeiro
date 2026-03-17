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

        /*if (naoGhostAction.WasPressedThisFrame())
        {
            NaoGhost();
        }*/
    }

    private void Awake()
    {
        ghostAction = InputSystem.actions.FindAction("Ghost");
        naoGhostAction = InputSystem.actions.FindAction("NaoGhost");
    }

    private void Ghost()
    {
        transform.localScale = new Vector3(0f, 0f, 0f);
        print("sla");
    }

    /*private void NaoGhost()
    {
        transform.localScale = new Vector3(2f, 2f, 2f);
        print("sla2");
    }*/

    /*IEnumerator WaitAndPrint()
    {
        yield return new WaitForSeconds(2);
    }

    IEnumerator Start()
    {
        yield return StartCoroutine("WaitAndPrint"); 
        print("sla");
    }*/
}
