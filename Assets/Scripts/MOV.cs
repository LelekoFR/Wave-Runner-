using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MOV : MonoBehaviour
{
    public float moveSpeed, jumpPower;
    public static int vidas = 4;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "gamewin") SceneManager.LoadScene("GameWin");
        else if (vidas<=0) SceneManager.LoadScene("GameOver"); else {
            lifes++;
            vidas--;
            SceneManager.LoadScene("fase");
            Debug.Log(vidas);
        }
    }

    private static int lifes;

    void OnGUI()
    {
        GUI.color = Color.red;
        if (lifes == 0) GUILayout.Label("Vidas: "+3);
        if (lifes == 2) GUILayout.Label("Vidas: " + 2);
        if (lifes == 4) GUILayout.Label("Vidas: " + 1);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * jumpPower * Time.deltaTime);
        if (Input.GetKey(KeyCode.Escape)) SceneManager.LoadScene("Menu");
        }
}