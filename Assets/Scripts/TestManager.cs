using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TestManager : MonoBehaviour
{
    public Text userInput;

    public Image imgFruit;

    public Image imgWrong;
    public Image imgRight;

    void Start()
    {
        imgWrong.enabled = false;
        imgRight.enabled = false;
          
        imgFruit.sprite = GameControl.manager.currentWord.image;
    }

    public void EraserSelected()
    {
        userInput.text = null;
    }

    public void EnterSelected()
    {
        string wordEntered = userInput.text.ToString().ToUpper();

        if (wordEntered == GameControl.manager.currentWord.word.ToUpper())
        {
            userInput.text = null;
            imgRight.enabled = true;

            int currentWordIndex = PlayerPrefs.GetInt("currentWordIndex");
            GameControl.wordsToLearn.RemoveAt(currentWordIndex);    //removes current word
            GameControl.manager.SetCurrentWord();   //Changes current word
            
            StartCoroutine(ChangeScene());
        }
        else
        {
            userInput.text = null;
            imgWrong.enabled = true;

            StartCoroutine(RemoveImg());
        }
    }

    IEnumerator RemoveImg()
    {
        yield return new WaitForSeconds(2);
        imgWrong.enabled = false;
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("1_learn");
    }
}
