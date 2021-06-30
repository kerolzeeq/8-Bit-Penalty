using UnityEngine;
using UnityEngine.UI;

public class blink : MonoBehaviour
{
    public Image bg;
    public Text taptoplay;

    public Color gray => Color.gray;
    public Color green => Color.green;
    public Color white => Color.white;

    public void Update()
    {
        bg.color = Lerp(gray,white,1.0f);
        taptoplay.color = Lerp(white,gray,4.0f);
    }
    
    public Color Lerp(Color first, Color second, float speed)
    {
        return Color.Lerp(first, second, Mathf.Sin(Time.time * speed));
    }

    

    
}
