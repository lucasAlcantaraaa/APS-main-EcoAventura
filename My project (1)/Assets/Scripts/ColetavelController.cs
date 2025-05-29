using System.Collections.Generic;
using UnityEngine;

public class ColetavelController : MonoBehaviour
{
    [Header("Lista dos Coletáveis")]
    [SerializeField] private List<GameObject> coletaveis;

    private int quantidadeParaAtivar;

    void Start()
    {
        DefinirQuantidadePorDificuldade();
        AtivarColetaveis();
    }

    void DefinirQuantidadePorDificuldade()
    {
        string dificuldade = PlayerPrefs.GetString("Dificuldade", "Facil"); // "Facil" é o padrão se não existir

        switch (dificuldade)
        {
            case "Facil":
                quantidadeParaAtivar = 8;
                break;
            case "Medio":
                quantidadeParaAtivar = 7;
                break;
            case "Dificil":
                quantidadeParaAtivar = 5;
                break;
            default:
                quantidadeParaAtivar = 5; // Caso não encontre, assume fácil
                break;
        }
    }

    void AtivarColetaveis()
    {
        foreach (GameObject coletavel in coletaveis)
        {
            coletavel.SetActive(false);
        }

        for (int i = 0; i < quantidadeParaAtivar; i++)
        {
            if (i < coletaveis.Count)
            {
                coletaveis[i].SetActive(true);
            }
        }
    }
}