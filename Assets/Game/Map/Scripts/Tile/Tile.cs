using UnityEngine;

public class Tile : MonoBehaviour
{
    private Collider2D Collider2D;
    public void SetTilePosition(float x, float y)
    {
        this.transform.position = new Vector2(x, y);
    }
    public void SetColliderEnabled(bool isEnabled)
    {
        this.Collider2D.enabled = isEnabled;
    }
}
