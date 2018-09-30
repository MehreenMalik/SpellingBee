using UnityEngine;
using UnityEngine.UI;

public class LearnManager : MonoBehaviour
{
    public Text word;
    public Image img;

    void Start ()
    {
        SetCurrentWord();
    }

    void SetCurrentWord()
    {
        word.text = GameControl.manager.currentWord.word;
        img.sprite = GameControl.manager.currentWord.image;
    }
}