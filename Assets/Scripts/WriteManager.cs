using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WriteManager : MonoBehaviour
{
    public Text userInput, txtTitle;

    public Button A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z, EnterButton;

    public Image imgFruit;

    int turn;
    public Image imgWrongOne;
    public Image imgRightOne;

    public Image imgWrongTwo;
    public Image imgRightTwo;

    public Image imgWrongThree;
    public Image imgRightThree;

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
        turn+=1;

        if(turn==1)
        {
            if (userInput.text == GameControl.manager.currentWord.word.ToUpper())
            {
                userInput.text = null;
                imgRightOne.enabled = true;
            }
            else
            {
                userInput.text = null;
                imgWrongOne.enabled = true;
            }
        }
        if (turn == 2)
        {
            if (userInput.text == GameControl.manager.currentWord.word.ToUpper())
            {
                userInput.text = null;
                imgRightTwo.enabled = true;
            }
            else
            {
                userInput.text = null;
                imgWrongTwo.enabled = true;
            }
        }
        if (turn == 3)
        {
            if (userInput.text == GameControl.manager.currentWord.word.ToUpper())
            {
                userInput.text = null;
                imgRightThree.enabled = true;
            }
            else
            {
                userInput.text = null;
                imgWrongThree.enabled = true;
            }
        }
        if (turn > 3)
        {
            //Change scenes popup
            SceneManager.LoadScene("3_test");
        }
    }
}
