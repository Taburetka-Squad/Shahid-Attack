using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Slider _progressBar;
    [SerializeField] private int _currentValue;
    [SerializeField] private int _maxValue;

    private void Awake()
    {
        _progressBar = GetComponent<Slider>();
        _progressBar.maxValue = _maxValue;

        UpdateInfo();
    }

    public bool TryAddValue(int value)
    {
        if(value > 0)
        {
            _currentValue += value;

            UpdateInfo();

            return true;
        }

        return false;
    }
    public bool TrySubtractValue(int value)
    {
        if(_currentValue >= value)
        {
            _currentValue -= value;

            UpdateInfo();

            return true;
        }

        return false;
    }

    private void UpdateInfo()
    {
        _progressBar.value = _currentValue / _progressBar.maxValue;
    }
}
