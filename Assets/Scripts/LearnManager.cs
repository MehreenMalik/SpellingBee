using UnityEngine;
using UnityEngine.UI;

public class LearnManager : MonoBehaviour
{
    public Text word;
    public Image imgFruit;

    void Start ()
    {
        SetCurrentWord();
    }

    void SetCurrentWord()
    {
        word.text = GameControl.manager.currentWord.word;
        imgFruit.sprite = GameControl.manager.currentWord.image;
    }
}