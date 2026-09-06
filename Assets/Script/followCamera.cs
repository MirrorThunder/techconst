using UnityEngine;

public class followCamera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame

	public GameObject player;
	private Vector3 offset = new Vector3(0, 8, -9); // (0, 5, -7);

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
