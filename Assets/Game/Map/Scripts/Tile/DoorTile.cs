using UnityEngine;

public class DoorTile : Tile
{
    public bool IsLocked;

    private void OnEnable()
    {
        if (IsLocked)
            SetColliderEnabled(true);
        else
            SetColliderEnabled(false);
    }

    private void Start()
    {
        
    }

    public void SetDoorLocked()
    {
        IsLocked = true;
        SetColliderEnabled(IsLocked);
    }
    public void SetDoorUnlocked()
    {
        IsLocked = false;
        SetColliderEnabled(IsLocked);
    }

}
