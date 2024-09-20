using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Entity
{
    public string name;
    public double xPosToSpawnAtLocal;
    public double yPosToSpawnAtLocal;

    public Entity(string name, double x, double y)
    {
        this.name = name;
        xPosToSpawnAtLocal = x;
        yPosToSpawnAtLocal = y;
    }

    [JsonConstructor]
    public Entity() { }
}
