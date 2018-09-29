using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour
{
    string category;

    public void LOAD_LEVEL_Categories()
    {
        SceneManager.LoadScene("0_categories");
    }

    public void LOAD_LEVEL_FRUIT()
    {
        category = "fruit";

        PlayerPrefs.SetString("categorySlected", category);
        SceneManager.LoadScene("1_learn");
    }

    public void LOAD_LEVEL_School()
    {
        category = "school";

        PlayerPrefs.SetString("categorySlected", category);
        SceneManager.LoadScene("1_learn");
    }

    public void LOAD_Write()
    {
        SceneManager.LoadScene("2_write");
    }

    public void LOAD_info()
    {
        SceneManager.LoadScene("5_info");
    }
}
