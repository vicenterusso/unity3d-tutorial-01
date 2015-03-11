using UnityEngine;

public class Box : MonoBehaviour
{


	void Awake()
	{
		// Inicia o listener
		InputManager.Instance.OnClick += OnBoxClick;
	}

    // Evento de click a ser executado
    void OnBoxClick(GameObject go)
    {
        if (go == gameObject)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
