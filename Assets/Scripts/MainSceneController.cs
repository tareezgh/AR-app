using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Add this line if using TextMeshPro

public class MainSceneController : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro; 
    public AudioSource audioSource;

     public GameObject Tanks;
    
    void Start()
    {
        Tanks.SetActive(false);
        textMeshPro.font = Resources.Load<TMP_FontAsset>("Fonts/HebrewFont");
        textMeshPro.alignment = TextAlignmentOptions.Right;
        
        
        textMeshPro.text = "שלום אתם נמצאים באנדרטאת חטבית השריון 971 האנדרטה הוקמה על מנת להנציח את לחימת הגבורה של החטיבה במלחמת יום הכיפורים, חטיבה 971 הוקמה באמצע שנות ה-05 של המאה הקודמת והייתה אחת משתי חטיבות השריון במילואים הראשונות של צה״ל החטיבה השתתפה במבצע קדש בסיני ובמלחמת ששת הימים בשמרון ובגולן";

        
    }

     void Update()
    {
        if (audioSource.isPlaying)
        {
            // Update the text based on the audio playback progress
            float playbackPercentage = audioSource.time / audioSource.clip.length;
            int currentWordIndex = Mathf.FloorToInt(playbackPercentage * textMeshPro.textInfo.wordCount);
            textMeshPro.maxVisibleWords = currentWordIndex + 1;
        }
        else
        {
            // The audio has stopped, hide the text
            textMeshPro.maxVisibleWords = 0;
            Tanks.SetActive(true);
        }
    }

    
}
