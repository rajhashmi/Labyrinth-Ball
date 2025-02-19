using UnityEngine;

public class CameraFollow : MonoBehaviour{

    private Vector3 offset;
    private GameObject player;


    void Awake(){
        player = GameObject.FindWithTag("Player");
        offset = transform.position - player.transform.position;
    }
    void Start()
    {
        
    }

    void Update(){

        if(player){
            transform.position = player.transform.position + offset;
        }
        
    }
}
