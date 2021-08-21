using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    public Texture2D crosshair;
    
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
        Cursor.SetCursor(crosshair, Vector3.zero, CursorMode.ForceSoftware);
    }

    private void Update()
    {
        var ray = cam.ScreenPointToRay(Input.mousePosition);
        var ground = new Plane(Vector3.up, Vector3.zero);

        if (ground.Raycast(ray, out var rayLength))
        {
            var point = ray.GetPoint(rayLength);
            transform.LookAt(new Vector3(point.x, transform.position.y, point.z));
        }
    }
}