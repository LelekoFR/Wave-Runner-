using UnityEngine;

public class DRAGON : MonoBehaviour
{
	public float moveSpeed;
	
	void Update()
	{
		transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
		
    }

}