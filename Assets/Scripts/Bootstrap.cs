using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class Bootstrap : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button sfxButton;
    [SerializeField] private AudioSource sfxSource;
    [SerializeField] private RectTransform settingsWidget;
    
    [Header("Settings")]
    [SerializeField] private int repetitions = 2;
    [SerializeField] private float delayInSeconds = 0.35f;
    
    private void Awake()
    {
        sfxButton.onClick.AddListener(OnSfxClick);
        settingsButton.onClick.AddListener(OnSettingsClick);
    }

    private void OnSettingsClick()
    {
        settingsWidget.gameObject.SetActive(true);
    }

    private void OnSfxClick()
    {
        StartSfxAsync().Forget();
    }

    private async UniTask StartSfxAsync()
    {
        for (int i = 0; i < repetitions; i++)
        {
            sfxSource.Play();
            await UniTask.WaitForSeconds(delayInSeconds);
        }
    }
}
