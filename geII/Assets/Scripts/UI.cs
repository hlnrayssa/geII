using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TMP_Text vidaUI;
    public TMP_Text levelUI;

    void Update()
    {
        //vidaUI e level UI irá trocar os textos Canvas para os valores da variáveis de vida e level no script Player
        vidaUI.text = "Vida: " + Player.Instance.vida.ToString();
        levelUI.text = "Level: " + Player.level.ToString();
    }


}
