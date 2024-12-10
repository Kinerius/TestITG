using UnityEngine;
using UnityEngine.UI;

public class SettingsWidget : MonoBehaviour
{
    [SerializeField] private Button emptySpace;

    private void Awake()
    {
        emptySpace.onClick.AddListener(OnEmptySpaceClicked);
    }

    private void OnEmptySpaceClicked()
    {
        gameObject.SetActive(false);
    }
}