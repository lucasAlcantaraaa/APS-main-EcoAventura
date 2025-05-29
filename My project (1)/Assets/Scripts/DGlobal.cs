using UnityEngine;

public class DGlobal : MonoBehaviour
{
    public static DGlobal instance;

    public enum Dificuldade { Facil, Medio, Dificil }
    public Dificuldade dificuldadeSelecionada;

    private void Awake()
    {
        // Garante que só existe um na cena e não destrói entre cenas
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetDificuldadeFacil()
    {
        dificuldadeSelecionada = Dificuldade.Facil;
    }

    public void SetDificuldadeMedia()
    {
        dificuldadeSelecionada = Dificuldade.Medio;
    }

    public void SetDificuldadeDificil()
    {
        dificuldadeSelecionada = Dificuldade.Dificil;
    }
}