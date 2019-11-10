using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.IO;
public class ScreenTexture : MonoBehaviour
{
    public int photoWidth = 50;
    public int photoHeight = 50;
    public int thumbProportion = 25;
    public Color borderColor = Color.white;
    public int borderWidth = 2;
    private Texture2D texture;
    private Texture2D border;
    private int screenWidth;
    private int screenHeight;
    private int frameWidth;
    private int frameHeight;
    private bool shoot = false;
    public int namepicture = 1;

    public string specis;

    // Start is called before the first frame update
    void Start()
    {
        screenWidth = Screen.width;
        screenHeight = Screen.height;
        frameWidth = Mathf.RoundToInt(screenWidth * photoWidth * 0.01f);
        frameHeight = Mathf.RoundToInt(screenHeight * photoHeight * 0.01f);
        texture = new Texture2D(frameWidth, frameHeight, TextureFormat.RGB24, false);
        border = new Texture2D(1, 1, TextureFormat.ARGB32, false);
        border.SetPixel(0, 0, borderColor);
        border.Apply();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGUI()
    {
        GUI.DrawTexture(new Rect((screenWidth * 0.5f) - (frameWidth * 0.5f) - borderWidth * 2, ((screenHeight * 0.5f) - (frameHeight * 0.5f)) - borderWidth, frameWidth + borderWidth * 2, borderWidth), border, ScaleMode.StretchToFill);
        GUI.DrawTexture(new Rect((screenWidth * 0.5f) - (frameWidth * 0.5f) - borderWidth * 2, (screenHeight * 0.5f) + (frameHeight * 0.5f), frameWidth + borderWidth * 2, borderWidth), border, ScaleMode.StretchToFill);
        GUI.DrawTexture(new Rect((screenWidth * 0.5f) - (frameWidth * 0.5f) - borderWidth * 2, (screenHeight * 0.5f) - (frameHeight * 0.5f), borderWidth, frameHeight), border, ScaleMode.StretchToFill);
        GUI.DrawTexture(new Rect((screenWidth * 0.5f) + (frameWidth * 0.5f), (screenHeight * 0.5f) - (frameHeight * 0.5f), borderWidth, frameHeight), border, ScaleMode.StretchToFill);
        if (shoot)
        {
            GUI.DrawTexture(new Rect(10, 10, frameWidth * thumbProportion * 0.01f, frameHeight * thumbProportion * 0.01f), texture, ScaleMode.StretchToFill);
        }
    }

}
public interface fruit
{
    IEnumerator CaptureScreen(string aname);
    IEnumerator UploadPNG(string aname);
}