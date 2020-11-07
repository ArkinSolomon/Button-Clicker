using UnityEngine;
using TMPro;
public class Counter : MonoBehaviour
{
    int timesPressed = 0;
    public TMP_Text counter;
    void Start()
    {       
        if (PlayerPrefs.HasKey("pressed"))
            timesPressed = PlayerPrefs.GetInt("pressed");
        counter.text = timesPressed.ToString();
    }
    public void Press()
    {
        timesPressed++;
        PlayerPrefs.SetInt("pressed", timesPressed);
        counter.text = timesPressed.ToString();
    }
}
