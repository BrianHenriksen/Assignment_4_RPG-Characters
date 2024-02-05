namespace Assignment_4.Character_classes;

public class Sorcerer:Character_class
{
    public Sorcerer(string name, string title) : base(name, title)
    {
        classDescription = "A loner who left formal academia to pursue further research." +
                           "Commands soul sorceries using high intelligence.";
    }
}