using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class QuizBoss : MonoBehaviour
{
    public GameObject painelQuiz;
    public TextMeshProUGUI textoPergunta;
    public Button[] botoesResposta;

    // Listas de perguntas para cada dificuldade
    public List<Pergunta> perguntasFacil;
    public List<Pergunta> perguntasMedio;
    public List<Pergunta> perguntasDificil;

    private List<Pergunta> perguntasAtuais;

    public string cenaCorreta;

    public void MostrarPergunta()
    {
        DefinirPerguntasPorDificuldade();

        if (perguntasAtuais == null || perguntasAtuais.Count == 0)
        {
            Debug.LogWarning("Sem perguntas para essa dificuldade!");
            return;
        }

        Pergunta p = perguntasAtuais[Random.Range(0, perguntasAtuais.Count)];

        textoPergunta.text = p.pergunta;

        for (int i = 0; i < botoesResposta.Length; i++)
        {
            int index = i;
            botoesResposta[i].GetComponentInChildren<TextMeshProUGUI>().text = p.opcoes[i];
            botoesResposta[i].onClick.RemoveAllListeners();

            botoesResposta[i].onClick.AddListener(() =>
            {
                if (index == p.indiceCorreto)
                {
                    SceneManager.LoadScene(cenaCorreta);
                }
                else
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            });
        }

        painelQuiz.SetActive(true);
    }

    void DefinirPerguntasPorDificuldade()
    {
        if (DifficultyManager.Instance == null)
        {
            Debug.LogWarning("DifficultyManager não encontrado!");
            perguntasAtuais = perguntasFacil; // padrão caso não ache
            return;
        }

        switch (DifficultyManager.Instance.currentDifficulty.bossQuestionDifficulty)
        {
            case 1:
                perguntasAtuais = perguntasFacil;
                break;
            case 2:
                perguntasAtuais = perguntasMedio;
                break;
            case 3:
                perguntasAtuais = perguntasDificil;
                break;
            default:
                perguntasAtuais = perguntasFacil;
                break;
        }
    }
}