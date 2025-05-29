using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoInicio : MonoBehaviour
{
    public void IniciarJogo()
    {
        SceneManager.LoadScene("MenuDificuldade"); // Carrega a cena MenuDificuldade
    }
}