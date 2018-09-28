using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class GameControl : MonoBehaviour
{
    public static GameControl manager;

    string categorySelected;
    public Word[] fruit, school;
    private static List<Word> wordsToLearn;
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

    void SetCurrentWord()
    {
        int randomWordIndex = Random.Range(0, wordsToLearn.Count);
        currentWord = wordsToLearn[randomWordIndex];
    }
}
