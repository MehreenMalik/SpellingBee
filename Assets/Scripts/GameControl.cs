using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl manager;

    string categorySelected;

    public Word[] fruit, school;
    public static List<Word> wordsToLearn;
    public Word currentWord;

    void Awake()
    {
        if (manager == null)
        {
            DontDestroyOnLoad(gameObject);
            manager = this;
        }
        else if (manager != this)
        {
            Destroy(gameObject);
        }

        categorySelected = PlayerPrefs.GetString("categorySlected");
    }

    void Start()
    {
        if (wordsToLearn == null || wordsToLearn.Count == 0)
        {
            if (categorySelected == "fruit")
            {
                wordsToLearn = fruit.ToList<Word>();
                SetCurrentWord();
            }
            else if (categorySelected == "school")
            {
                wordsToLearn = school.ToList<Word>();
                SetCurrentWord();
            }
        }
    }

    public void SetCurrentWord()
    {
        if(wordsToLearn == null || wordsToLearn.Count == 0)
        {
            Debug.Log("Word list ended");

            if (categorySelected == "fruit") //repopulate wordsToLearn list
            {
                wordsToLearn = fruit.ToList<Word>();
                SetCurrentWord();
            }
            else if (categorySelected == "school")
            {
                wordsToLearn = school.ToList<Word>();
                SetCurrentWord();
            }

            //Change to end category scene
            SceneManager.LoadScene("4_endCategory");
        }
        else
        {
            int randomWordIndex = Random.Range(0, wordsToLearn.Count);
            currentWord = wordsToLearn[randomWordIndex];

            PlayerPrefs.SetInt("currentWordIndex", randomWordIndex);

            Debug.Log("Current word: " + currentWord.word);
        }
    }
}
