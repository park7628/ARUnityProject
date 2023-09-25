using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine.UI;
using UnityEditor;

public class PlanetInfo : MonoBehaviour {

    private List<string> infoList { get; set; }
    public Text contentText;
    public Text planetNameText;
    private RectTransform rectTransform;
    public float dpi = 5;
    private PlanetManager planetSwitchScript;
    private TextAsset resourceFile;
    public static PlanetInfo instance = null;

    void Awake()
	{
		if(instance == null)
		{
			instance = this;
		}
		else if(instance != this)
		{
			Destroy(gameObject);
		}
           rectTransform = contentText.GetComponent<RectTransform>();

	}

    public void LoadTextToScrollBar(string name)
    {
        resourceFile = Resources.Load(name) as TextAsset;
        
        // clear content
        contentText.text = string.Empty;

        if(resourceFile != null)
        {
            // mobile, desktop and webgl
            contentText.text += resourceFile.text;
            rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, resourceFile.text.Length * dpi);
        }
        else
        {
            // No info for planet - please add PlanetName.txt to SolarSystem/PlanetInfo
            contentText.text = string.Format("Please add {0}.txt to Resources folder", name);
        }

        planetNameText.text = name;
    }
}
