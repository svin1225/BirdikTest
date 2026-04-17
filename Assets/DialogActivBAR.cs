using TMPro;
using UnityEngine;

public class DialogActivBAR : MonoBehaviour
{
    public TextMeshProUGUI TextNext;
    public static bool DialogFinished = false;
    public GameObject HeroDialog;
    public GameObject BarDialog;
    private int count;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        count = 0;
        scoreText.text = "здрасте";
        BarDialog.SetActive(true);
        HeroDialog.SetActive(false);
    }


    public void OnButtonDialogContin()
    {

    }
}
