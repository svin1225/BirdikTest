using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class DialogActiv : MonoBehaviour
{
    private int count;
    public TextMeshProUGUI scoreText;  
    void Start()
    {
        count = 0;
        scoreText.text = "здарова";
    }
    public void OnButtonDialogContin()
    {
        scoreText.text = "Чё";
        count = count + 1;

        if (count == 2)
        {
            scoreText.text = "я тебя раньше не видел малой";
            count += 1;
        }

        if (count == 4)
        {
            scoreText.text = "Брат не пугай меня";
            count += 1;
        }

        if (count == 6)
        {
            scoreText.text = "пойдём тут очень много что показать чел";
            count += 1;
        }

        if (count == 8)
        {
            scoreText.text = "Ладно";
            count = 0;
        }
    }



}

//здарова

//Чё

//я тебя раньше не видел малой

//Брат не пугай меня

//пойдём тут очень много что показать чел

//Ладно
