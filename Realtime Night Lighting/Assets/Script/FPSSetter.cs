using UnityEngine;

public class FPSSetter : MonoBehaviour{
    [Range(24, 300)]
    [SerializeField] private int maxFPS = 60;
    private void Awake(){
        Application.targetFrameRate = maxFPS;
    }
}
