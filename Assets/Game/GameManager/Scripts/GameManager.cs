using UnityEngine;

public class GameManager : MonoBehaviour
{

    public delegate void EventManager();
    public static event EventManager OnEnterRoom;
    public static event EventManager OnRoomCleared;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (OnEnterRoom != null)
                OnEnterRoom();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (OnRoomCleared != null)
                OnRoomCleared();
        }
    }


}
