using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{

	public Texture2D background;
	public Texture2D titulo;


	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnGUI()
	{

		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), background);
		GUI.DrawTexture(new Rect(225, 50, 150, 40), titulo);

		if (Input.GetKey(KeyCode.Return))
		{
			Application.LoadLevel("fase");
		}

		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();

			GUI.EndGroup();
		}
	}

}