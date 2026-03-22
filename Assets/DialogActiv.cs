using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class DialogActiv : MonoBehaviour
{
    public GameObject HeroDialog;
    public GameObject MerchDialog;
    private int count;
    public TextMeshProUGUI scoreText;  
    void Start()
    {
        count = 0;
        scoreText.text = "здарова";
        MerchDialog.SetActive(true);
        HeroDialog.SetActive(false);
    }
    public void OnButtonDialogContin()
    {
        scoreText.text = "Чё";
        count = count + 1;
        MerchDialog.SetActive(false);
        HeroDialog.SetActive(true);

        if (count == 2)
        {
            scoreText.text = "я тебя раньше не видел малой";
            count += 1;
            MerchDialog.SetActive(true);
            HeroDialog.SetActive(false);
        }

        if (count == 4)
        {
            scoreText.text = "Брат не пугай меня";
            count += 1;
            MerchDialog.SetActive(false);
            HeroDialog.SetActive(true);
        }

        if (count == 6)
        {
            scoreText.text = "пойдём тут очень много что показать чел";
            count += 1;
            MerchDialog.SetActive(true);
            HeroDialog.SetActive(false);
        }

        if (count == 8)
        {
            scoreText.text = "Ладно";
            count = 0;
            MerchDialog.SetActive(false);
            HeroDialog.SetActive(true);
        }
    }



}

//здарова

//Чё

//я тебя раньше не видел малой

//Брат не пугай меня

//пойдём тут очень много что показать чел

//Ладно
