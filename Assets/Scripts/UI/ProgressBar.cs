using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Slider _progressBar;
    [SerializeField] private float _currentValue;
    [SerializeField] private int _maxValue = 100;

    private void Awake()
    {
        _progressBar = GetComponent<Slider>();

        UpdateInfo();
    }

    public void TryAddValue(int value)
    {
        if(value > 0)
        {
            _currentValue += value;

            UpdateInfo();
        }
    }
    public void TrySubtractValue(int value)
    {
        if(_currentValue >= value)
        {
            _currentValue -= value;

            UpdateInfo();
        }
    }

    private void UpdateInfo()
    {
        if(_currentValue == 0)
        {
            _progressBar.value = 0;
        }
        else
        {
            _progressBar.value = _currentValue / _maxValue;
        }
    }
}
