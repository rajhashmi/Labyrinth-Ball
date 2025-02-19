using UnityEngine;

public class CameraFollow : MonoBehaviour{

    private Vector3 offset;
    private GameObject player;


    void Awake(){
        player = GameObject.FindWithTag("Player");
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
