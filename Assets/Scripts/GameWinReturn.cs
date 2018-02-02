using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWinReturn : MonoBehaviour {

	public Texture2D background;
	public float duracao;
	private float contagem;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		contagem += Time.deltaTime;
		if (contagem >= duracao) {
            SceneManager.LoadScene("Menu");
        }
	}
    
}