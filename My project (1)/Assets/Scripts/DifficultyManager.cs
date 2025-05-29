using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public static DifficultyManager Instance;

    [Header("Configurações de Dificuldade")]
    public DifficultySettings dificuldadeFacil;
    public DifficultySettings dificuldadeMedia;
    public DifficultySettings dificuldadeDificil;

    [Header("Dificuldade Atual")]
    public DifficultySettings currentDifficulty;

    private void Awake()
    {
        // Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Mantém entre cenas
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Métodos para selecionar a dificuldade
    public void SetFacil()
    {
        currentDifficulty = dificuldadeFacil;
        Debug.Log("Dificuldade selecionada: Fácil");
    }

    public void SetMedia()
    {
        currentDifficulty = dificuldadeMedia;
        Debug.Log("Dificuldade selecionada: Média");
    }

    public void SetDificil()
    {
        currentDifficulty = dificuldadeDificil;
        Debug.Log("Dificuldade selecionada: Difícil");
    }
}