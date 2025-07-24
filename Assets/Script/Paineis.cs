using UnityEngine;

public class GerenciadorPaineis : MonoBehaviour
{
    public GameObject painel1;
    public GameObject painel2;
    public GameObject painel3;
    public GameObject painel4;
    public GameObject painel5;

    public void MostrarPainel(string nomePainel)
    {
        painel1.SetActive(nomePainel == "Panel1");
        painel2.SetActive(nomePainel == "Panel2");
        painel3.SetActive(nomePainel == "Panel3");
        painel4.SetActive(nomePainel == "Panel4");
        painel5.SetActive(nomePainel == "Panel5");
    }
}