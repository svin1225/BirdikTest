using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;

public class DialogActiv : MonoBehaviour
{
    public GameObject Canvas;
    public TextMeshProUGUI TextNext;
    public static bool DialogFinished = false;
    public GameObject HeroDialog;
    public GameObject MerchDialog;
    private int count;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        count = 0;
        scoreText.text = "Здарова";
        MerchDialog.SetActive(true);
        HeroDialog.SetActive(false);
    }
    public void OnButtonDialogContin()
    {     
        {
            Debug.Log("TTTTTTT");
            scoreText.text = "Чё";
            count = count + 1;
            MerchDialog.SetActive(false);
            HeroDialog.SetActive(true);

            if (count == 2)
            {
                scoreText.text = "Я слышал ты тут толкать собрался";
                count += 1;
                MerchDialog.SetActive(true);
                HeroDialog.SetActive(false);
            }

            if (count == 4)
            {
                scoreText.text = "Ну да бомбезное место";
                count += 1;
                MerchDialog.SetActive(false);
                HeroDialog.SetActive(true);
            }

            if (count == 6)
            {
                scoreText.text = "Я бы так не сказал мабой. Тут такие черты обитают что в свободную сторону не пошагнешь ";
                count += 1;
                MerchDialog.SetActive(true);
                HeroDialog.SetActive(false);
            }

            if (count == 8)
            {
                scoreText.text = "В этом и суть, я за ними пришёл";
                count += 1;
                MerchDialog.SetActive(false);
                HeroDialog.SetActive(true);
            }

            if (count == 10)
            {
                scoreText.text = "А ты сам откуда";
                count += 1;
                MerchDialog.SetActive(true);
                HeroDialog.SetActive(false);
            }

            if (count == 12)
            {
                scoreText.text = "Краснодар";
                count += 1;
                MerchDialog.SetActive(false);
                HeroDialog.SetActive(true);
            }

            if (count == 14)
            {
                scoreText.text = "Тогда понятно";
                count += 1;
                MerchDialog.SetActive(true);
                HeroDialog.SetActive(false);
            }

            if (count == 16)
            {
                scoreText.text = "А ты здешний?";
                count += 1;
                MerchDialog.SetActive(false);
                HeroDialog.SetActive(true);
            }

            if (count == 18)
            {
                scoreText.text = "К сожалению, я тут родился";
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

            if (count == 52)
            {
                scoreText.text = "?";
                count += 1;
                MerchDialog.SetActive(false);
                HeroDialog.SetActive(true);
            }

            if (count == 54)
            {
                scoreText.text = "Скажешь то что ты от Ванька";
                count += 1;
                MerchDialog.SetActive(true);
                HeroDialog.SetActive(false);
            }

            if (count == 56)
            {
                scoreText.text = "Ты Ванёк?";
                count += 1;
                MerchDialog.SetActive(false);
                HeroDialog.SetActive(true);
            }

            if (count == 58)
            {
                scoreText.text = "Да я Ванёк";
                count += 1;
                MerchDialog.SetActive(true);
                HeroDialog.SetActive(false);
            }

            if (count == 60)
            {
                scoreText.text = "Спасибо, Ванёк";
                count += 1;
                MerchDialog.SetActive(false);
                HeroDialog.SetActive(true);
            }

            if (count == 62)
            {
                scoreText.text = "Ну всё давай мабой";
                count += 1;
                MerchDialog.SetActive(true);
                HeroDialog.SetActive(false);
            }

            if (count == 64)
            {
                scoreText.text = "Ну всё давай";
                count += 1;
                MerchDialog.SetActive(false);
                HeroDialog.SetActive(true);
            }

            if (count == 66)
            {
                scoreText.text = "Ну давай";
                count += 1;
                MerchDialog.SetActive(true);
                HeroDialog.SetActive(false);
                TextNext.text = "Погнали";
            }

            if (count == 68)
            {
                DialogFinished = true;
                count = -1;
            }

        }
 
    }



}

//Здарова

//Чё

//Я слышал ты тут толкать собрался

//Ну да бомбезное место

//Я бы так не сказал мабой. Тут такие черты обитают что в свободную сторону не пошагнешь 

//В этом и суть, я за ними пришёл

//А ты сам откуда

//Краснодар

//Тогда понятно откуда такое бесстрашие

//А ты здешний?

//К сожалению, я тут родился

//К сожалению родился?

//К сожалению тут

//Ага

//Слушай, я ведь тоже не из этих. Давай вместе работать

//Без вопросов

//Отлично, но для начала ты бар должен найти. Он недалеко отсюда. В буквальном смысле за углом

//Хорошо а зачем

//Ну там дядя бородатый сидит, он единственный чем бизнес не сдвинули с рынка

//Это он настолько хорош?

//Не, просто всем лишь бы побухать

//А

//Ну так вот, он тебе и даст первое задание

//Какое?

//Не знаю. Он по настроению их даёт

//Ага

//А еще

//?

//Скажешь то что ты от Ванька

//Ты Ванёк?

//Да я Ванёк

//Спасибо, Ванёк

//Ну всё давай мабой

//Ну всё давай

//ну давай