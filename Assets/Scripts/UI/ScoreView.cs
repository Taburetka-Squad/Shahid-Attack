using UnityEngine;
using TMPro;

class ScoreView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private string Format = "SCORE: {0}";

    public void Initialize(ScoreInteractor scoreInteractor)
    {
        scoreInteractor.Changed += UpdateText;
    }
    private void UpdateText(int score)
    {
        _text.text = string.Format(Format, score);
    }
}
