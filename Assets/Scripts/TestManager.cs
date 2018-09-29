using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TestManager : MonoBehaviour
{
    public Text userInput;

    public Button A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z, EnterButton;

    public Image imgFruit;

    public Image imgWrong;
    public Image imgRight;

    void Start()
    {
        imgWrong.enabled = false;
        imgRight.enabled = false;
          
        imgFruit.sprite = GameControl.manager.currentWord.image;
    }

    public void ASelected()
    {
        string selected = A.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void BSelected()
    {
        string selected = B.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void CSelected()
    {
        string selected = C.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void DSelected()
    {
        string selected = D.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void ESelected()
    {
        string selected = E.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void FSelected()
    {
        string selected = F.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void GSelected()
    {
        string selected = G.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void HSelected()
    {
        string selected = H.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void ISelected()
    {
        string selected = I.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void JSelected()
    {
        string selected = J.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void KSelected()
    {
        string selected = K.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void LSelected()
    {
        string selected = L.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void MSelected()
    {
        string selected = M.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void NSelected()
    {
        string selected = N.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void OSelected()
    {
        string selected = O.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void PSelected()
    {
        string selected = P.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void QSelected()
    {
        string selected = Q.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void RSelected()
    {
        string selected = R.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void SSelected()
    {
        string selected = S.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void TSelected()
    {
        string selected = T.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void USelected()
    {
        string selected = U.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void VSelected()
    {
        string selected = V.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void WSelected()
    {
        string selected = W.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void XSelected()
    {
        string selected = X.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void YSelected()
    {
        string selected = A.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void ZSelected()
    {
        string selected = A.GetComponentInChildren<Text>().text;
        userInput.text += selected;
    }

    public void EraserSelected()
    {
        userInput.text = null;
    }

    public void EnterSelected()
    {
        if (userInput.text == GameControl.manager.currentWord.word.ToUpper())
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
