using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private Transform MainPanel;
    [SerializeField] private Transform DialogPanel;

    void Start()
    {
        DialogManager.Instance.OnWake(DialogPanel);
    }
}
