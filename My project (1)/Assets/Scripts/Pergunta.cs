using UnityEngine;

[System.Serializable]
public class Pergunta
{
    public string pergunta;
    public string[] opcoes = new string[4]; // Deve ter 4
    public int indiceCorreto; // Índice da resposta correta (0 a 3)
}
