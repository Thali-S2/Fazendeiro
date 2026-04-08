using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuiPrincipal : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private string nomeDoMenu;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;
    [SerializeField] private GameObject pause;
    [SerializeField] private GameObject telaConfirmar;
    public void Jogar()
    {
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }
    public void VoltarMenu()
    {
        SceneManager.LoadScene(nomeDoMenu);
    }
    public void AbrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void FecharOpcoes()
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }

    public void SairJogo()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }

    public void AbrirTelaPause()
    {
        
    }

    public void AbrirTelaConfirmar()
    {
        painelMenuInicial.SetActive(false);
        telaConfirmar.SetActive(true);

    }

    public void FecharTelaConfirmar()
    {
        telaConfirmar.SetActive(false);
        painelMenuInicial.SetActive(true);

    }
}
