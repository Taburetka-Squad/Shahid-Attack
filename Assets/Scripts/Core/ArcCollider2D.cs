using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(EdgeCollider2D))]
public class ArcCollider2D : MonoBehaviour {

    [Range(1, 25)]
    public float radius;
    [Range(1, 25)]
    public float Thickness;
    [Range(10,90)]
    public int smoothness;

    [Range(10, 360)]
    public int totalAngle;

    [Range(0, 360)]
    public int offsetRotation;
    
    public bool isSector;
    
    public Vector2[] getPoints(Vector2 offset)
    {
        List<Vector2> points = new List<Vector2>();

        var origin = Vector2.zero;
        var center = origin + offset;

        float ang = offsetRotation;

        if (isSector && totalAngle % 360 != 0)
        {
            points.Add(center);
        }

        for (var i = 0; i <= smoothness; i++)
        {
            var x = radius * Mathf.Cos(ang * Mathf.Deg2Rad);
            var y = radius * Mathf.Sin(ang * Mathf.Deg2Rad);

            points.Add(new Vector2(x, y));
            ang += (float)totalAngle/smoothness;
        }

        if (!isSector)
        {
            for (var i = 0; i <= smoothness; i++)
            {
                ang -= (float)totalAngle / smoothness;
                var x = (radius - Thickness) * Mathf.Cos(ang * Mathf.Deg2Rad);
                var y = (radius - Thickness) * Mathf.Sin(ang * Mathf.Deg2Rad);

                points.Add(new Vector2(x, y));
            }
        }

        if (isSector && totalAngle % 360 != 0) points.Add(center);

        return points.ToArray();
    }

    private void OnValidate()
    {
        var edgeCollider2D = gameObject.GetComponent<EdgeCollider2D>();
        edgeCollider2D.points = getPoints(Vector2.zero);
    }
}