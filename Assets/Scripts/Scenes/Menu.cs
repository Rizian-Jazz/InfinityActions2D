using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Iniciar() 
    {
        SceneManager.LoadScene("Jogo");
    } 
    public void Configuracoes() 
    {
        SceneManager.LoadScene("Configuracoes");
    }
    public void Creditos() 
    {
        SceneManager.LoadScene("Creditos");
    }
    public void Sair()     
    {
        Application.Quit();
        
    }
    public void Voltar() 
    {
        SceneManager.LoadScene("Menu");
    }
}
