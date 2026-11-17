using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGame : MonoBehaviour
{
    public Dropdown dropResolucoes;
    List<string> resolucoes = new List<string>();//lista pesa mais na memória do que um array

    Resolution[] listaResolucoes;
    public Toggle checkFull;


  
    void Start()
    {
        Screen.fullScreen = checkFull.isOn;
        listaResolucoes = Screen.resolutions;
        CriarListaResolucoes();

        /*resolucoes.Add("250 x 250");
        dropResolucoes.AddOptions(resolucoes);*/
    }

    void CriarListaResolucoes()
    {
        foreach (Resolution resAtual in listaResolucoes)
        {
            resolucoes.Add(resAtual.width + " x " + resAtual.height);
        }
        dropResolucoes.AddOptions(resolucoes);
    }

        // Update is called once per frame
    void Update()
    {

    }

    public void AplicarResolucao(int indice)
    {
        /*if (indice == 0)
        {
            
        }
        else if (indice == 1)
        {
            Screen.SetResolution(1280, 720, false);
        }
        else if (indice == 2)
        {
          */

        Screen.SetResolution(listaResolucoes[indice].width, listaResolucoes[indice].height, checkFull.isOn);
    }

    public void CheckFullScreen(bool value)
    {
        Screen.fullScreen = value;
    }
}

