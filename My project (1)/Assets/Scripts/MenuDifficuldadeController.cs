using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuDifficuldadeController : MonoBehaviour
{
    // Métodos públicos para chamar nos botões
    public void SelecionarFacil()
    {
        PlayerPrefs.SetString("Dificuldade", "Facil");
        CarregarCena1();
    }

    public void SelecionarMedio()
    {
        PlayerPrefs.SetString("Dificuldade", "Medio");
        CarregarCena1();
    }

    public void SelecionarDificil()
    {
        PlayerPrefs.SetString("Dificuldade", "Dificil");
        CarregarCena1();
    }

    void CarregarCena1()
    {
        SceneManager.LoadScene("Cena1");
    }
}
