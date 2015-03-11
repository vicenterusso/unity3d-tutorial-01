using UnityEngine;
using UnityEngine.UI;

public class ExecuteButton : MonoBehaviour
{

    void Awake()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(() => InputManager.Instance.ButtonExecute());
    }

}
