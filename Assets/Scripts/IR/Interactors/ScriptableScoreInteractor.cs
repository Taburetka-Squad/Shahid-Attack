using UnityEngine;

using IRCore;

[CreateAssetMenu(menuName = "Game/Interactors/Money")]
class ScriptableScoreInteractor : ScriptableValueInteractor<ScoreInteractor, ScoreRepository, int> { }