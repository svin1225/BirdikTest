using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class DialogManagement : MonoBehaviour
{
    public GameObject MerchDialog;
    public GameObject HeroDialog;
    public GameObject BarDialog;
    private int count;
    public TextMeshProUGUI scoreText;
    public GameObject Canvas;
    static private bool Bar;
    static private bool merch;

    void Start()
    {
        
    }


    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bar"))
        {
            Canvas.SetActive(true);
            count = 0;
            scoreText.text = "Наколи мне бэм бэм бэм......";
            HeroDialog.SetActive(false); 
            BarDialog.SetActive(true);
            MerchDialog.SetActive(false);
            Debug.Log("Триггер");
        }

    }

    public void OnButtonDialogContin()
    {
        scoreText.text = "О дядь";
        count = count + 1;
        HeroDialog.SetActive(true);
        BarDialog.SetActive(false);

        if (count == 2)
        {
            scoreText.text = "О сыноккк";
            count += 1;
            HeroDialog.SetActive(false);
            BarDialog.SetActive(true);
        }

        if (count == 4)
        {
            scoreText.text = "Всмысле";
            count += 1;
            MerchDialog.SetActive(false);
            HeroDialog.SetActive(true);
        }

        if (count == 6)
        {
            scoreText.text = "Сына только ты можешь меня понять.........";
            count += 1;
            MerchDialog.SetActive(true);
            HeroDialog.SetActive(false);
        }

        if (count == 8)
        {
            scoreText.text = "Дядь всё нормально";
            count += 1;
            MerchDialog.SetActive(false);
            HeroDialog.SetActive(true);
        }

        if (count == 10)
        {
            scoreText.text = "Сынок давай выпьем как мужик с мужиком";
            count += 1;
            MerchDialog.SetActive(true);
            HeroDialog.SetActive(false);
        }

        if (count == 12)
        {
            scoreText.text = "Только ты и я........";
            count += 1;
            MerchDialog.SetActive(false);
            HeroDialog.SetActive(true);
        }

        if (count == 14)
        {
            scoreText.text = "Без всяких этих....";
            count += 1;
            MerchDialog.SetActive(true);
            HeroDialog.SetActive(false);
        }

        if (count == 16)
        {
            scoreText.text = "БАБ";
            count += 1;
            MerchDialog.SetActive(false);
            HeroDialog.SetActive(true);
        }

        if (count == 18)
        {
            scoreText.text = "И предателей";
            count += 1;
            MerchDialog.SetActive(true);
            HeroDialog.SetActive(false);
        }

        if (count == 20)
        {
            scoreText.text = "К сожалению родился?";
            count += 1;
            MerchDialog.SetActive(false);
            HeroDialog.SetActive(true);
        }

        if (count == 22)
        {
            scoreText.text = "К сожалению тут";
            count += 1;
            MerchDialog.SetActive(true);
            HeroDialog.SetActive(false);
        }

        if (count == 24)
        {
            scoreText.text = "Ага";
            count += 1;
            MerchDialog.SetActive(false);
            HeroDialog.SetActive(true);
        }

        if (count == 26)
        {
            scoreText.text = "Слушай, я ведь тоже не из этих. Давай вместе работать";
            count += 1;
            MerchDialog.SetActive(true);
            HeroDialog.SetActive(false);
        }

        if (count == 28)
        {
            scoreText.text = "Без вопросов";
            count += 1;
            MerchDialog.SetActive(false);
            HeroDialog.SetActive(true);
        }

        if (count == 30)
        {
            scoreText.text = "Отлично, но для начала ты бар должен найти. Он недалеко отсюда. В буквальном смысле за углом";
            count += 1;
            MerchDialog.SetActive(true);
            HeroDialog.SetActive(false);
        }

        if (count == 32)
        {
            scoreText.text = "Хорошо а зачем";
            count += 1;
            MerchDialog.SetActive(false);
            HeroDialog.SetActive(true);
        }

        if (count == 34)
        {
            scoreText.text = "Ну там дядя бородатый сидит, он единственный чей бизнес не сдвинули с рынка";
            count += 1;
            MerchDialog.SetActive(true);
            HeroDialog.SetActive(false);
        }

        if (count == 36)
        {
            scoreText.text = "Это он настолько хорош?";
            count += 1;
            MerchDialog.SetActive(false);
            HeroDialog.SetActive(true);
        }

        if (count == 38)
        {
            scoreText.text = "Не, просто всем лишь бы побухать";
            count += 1;
            MerchDialog.SetActive(true);
            HeroDialog.SetActive(false);
        }

        if (count == 40)
        {
            scoreText.text = "А";
            count += 1;
            MerchDialog.SetActive(false);
            HeroDialog.SetActive(true);
        }

        if (count == 42)
        {
            scoreText.text = "Ну так вот, он тебе и даст первое задание";
            count += 1;
            MerchDialog.SetActive(true);
            HeroDialog.SetActive(false);
        }

        if (count == 44)
        {
            scoreText.text = "Какое?";
            count += 1;
            MerchDialog.SetActive(false);
            HeroDialog.SetActive(true);
        }

        if (count == 46)
        {
            scoreText.text = "Не знаю. Он по настроению их даёт";
            count += 1;
            MerchDialog.SetActive(true);
            HeroDialog.SetActive(false);
        }

        if (count == 48)
        {
            scoreText.text = "Ага";
            count += 1;
            MerchDialog.SetActive(false);
            HeroDialog.SetActive(true);
        }

        if (count == 50)
        {
            scoreText.text = "А еще";
            count += 1;
            MerchDialog.SetActive(true);
            HeroDialog.SetActive(false);
        }
    }
}
