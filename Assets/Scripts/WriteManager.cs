using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WriteManager : MonoBehaviour
{
    public Text txtTitle;
    public Image imgFruit;
    public InputField userInput;

    int turn;
    public Image imgWrongOne;
    public Image imgRightOne;

    public Image imgWrongTwo;
    public Image imgRightTwo;

    public Image imgWrongThree;
    public Image imgRightThree;

    string categorySelected;

    void Start()
    {
        turn = 0;
        imgWrongOne.enabled = false;
        imgRightOne.enabled = false;

        imgWrongTwo.enabled = false;
        imgRightTwo.enabled = false;

        imgWrongThree.enabled = false;
        imgRightThree.enabled = false;

        txtTitle.text = GameControl.manager.currentWord.word;
        imgFruit.sprite = GameControl.manager.currentWord.image;
    }

    public void EnterSelected()
    {
        turn +=1;
        string wordEntered = userInput.text.ToString().ToUpper();

        if (turn==1)
        {
            if (wordEntered == txtTitle.text.ToUpper())
            {
                userInput.text = "";
                imgRightOne.enabled = true;
            }
            else
            {
                userInput.text = "";
                imgWrongOne.enabled = true;
            }
        }
        if (turn == 2)
        {
            if (wordEntered == txtTitle.text.ToUpper())
            {
                userInput.text = "";
                imgRightOne.enabled = true;
            }
            else
            {
                userInput.text = "";
                imgWrongOne.enabled = true;
            }
        }
        if (turn == 3)
        {
            if (wordEntered == txtTitle.text.ToUpper())
            {
                userInput.text = "";
                imgRightOne.enabled = true;
            }
            else
            {
                userInput.text = "";
                imgWrongOne.enabled = true;
            }
        }
        if (turn > 3)
        {
            //Change scenes popup
            SceneManager.LoadScene("3_test");
        }
    }

    public void LOAD_LEVEL_Categories()
    {
        GameControl.wordsToLearn = null;
        GameControl.manager = null;
        SceneManager.LoadScene("0_categories");
    }
}
