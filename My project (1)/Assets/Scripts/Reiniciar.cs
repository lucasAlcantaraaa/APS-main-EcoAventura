using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    public void ReiniciarJogo()
    {
        SceneManager.LoadScene("Inicio"); // Carrega a primeira cena
    }
}