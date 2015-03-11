using UnityEngine;

public class BoxDinamico: MonoBehaviour
{

	public Color Cor;
	
	void Awake()
	{
		// Inicia o listener
		InputManager.Instance.OnButtonClick += ChangeColor;
	}

	void OnDestroy() {
		InputManager.Instance.OnButtonClick -= ChangeColor;
	}


	// Evento de combo a ser adicionado
	public void ChangeColor()
	{
		GameObject.Find(name).GetComponent<Renderer>().material.color = Cor;
	}



}
