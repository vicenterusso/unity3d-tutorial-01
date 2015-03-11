using UnityEngine;

public class InputManager : MonoBehaviour 
{

	// InputManager.Instance
	static InputManager _instance;
	
	public static InputManager Instance
	{
		
		get
		{
			if (_instance == null)
			{
				Debug.Log("Nova Instancia");
				_instance = new GameObject("InputManager").AddComponent<InputManager>();
			}
			
			return _instance;
		}
	
		
	}

	// Assinatura do Delegate
	public delegate void OnClickEvent(GameObject go);
	
	// Evento
	public event OnClickEvent OnClick;

	// Assinatura do AddComboClick sem parametros
	public delegate void AddComboClick();
	
	// Evento button execute click
	public event AddComboClick OnButtonClick;
	
	public void ButtonExecute()
	{
		OnButtonClick();
	}

	private void Update()
	{
				
		// Captura do MouseClick
		if (Input.GetMouseButtonUp(0))
		{
			var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, 100))
			{
				if (OnClick != null)
					OnClick(hit.transform.gameObject);
				
			}
		}
	}
}