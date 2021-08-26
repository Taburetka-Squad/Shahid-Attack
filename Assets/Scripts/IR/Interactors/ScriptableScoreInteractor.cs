using UnityEngine;

using IRCore;

[CreateAssetMenu(menuName = "IR/Interactors/Money")]
class ScriptableScoreInteractor : ScriptableValueInteractor<ScoreInteractor, ScoreRepository, int> { }