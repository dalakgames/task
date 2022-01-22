using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TaskUtils 
{
    public static void DrawCircle(Vector2 pos, float radius, Color color)
    {
        var material = new Material(Resources.Load<Material>("material"))
        {
            color = color
        };
        var circleMesh = Resources.Load<Mesh>("circle");

        var m = Matrix4x4.TRS(pos, Quaternion.Euler(-90,0,0), radius * Vector3.one);
        Graphics.DrawMesh(circleMesh,m,material,0,Camera.main);
    }

    public static void DrawLine(Vector2 p1, Vector2 p2, float lineWidth, Color color)
    {
        var material = new Material(Resources.Load<Material>("material"))
        {
            color = color
        };
        
        var squareMesh = Resources.Load<Mesh>("square");


        var pos = (p1 + p2) * 0.5f;
        float angle = Vector3.SignedAngle(Vector3.up, (Vector3) (p1 - p2), Vector3.forward);
        var rot = Quaternion.Euler(0,0,angle) * Quaternion.Euler(-90,  0,0);
        
        var m = Matrix4x4.TRS(pos, rot, new Vector3(lineWidth * 0.5f,1,Vector2.Distance(p1,p2) * 0.5f));
        Graphics.DrawMesh(squareMesh,m,material,0,Camera.main);
    }

    public static Vector2 MouseWorldPos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    public static bool IsMouseButtonDownThisFrame()
    {
        return Input.GetMouseButtonDown(0);
    }
    
    public static bool IsMouseButtonDown()
    {
        return Input.GetMouseButton(0);
    }

    public static bool IsMouseButtonUp()
    {
        return Input.GetMouseButtonUp(0);
    }
    
    
    
    
}
