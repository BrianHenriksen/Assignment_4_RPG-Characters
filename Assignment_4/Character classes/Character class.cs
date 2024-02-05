using Assignment_4.Weapons;

namespace Assignment_4.Character_classes;

public class Character_class
{
    protected String name;
    protected String title;
    protected String classDescription;
    protected Weapon weapon;
    

    public Character_class(String name, String title)
    {
        this.name = name;
        this.title = title;
    }

    public String GetName()
    {
        return name;
    }

    public String GetTitle()
    {
        return title;
    }

    public String GetClassDescription()
    {
        return classDescription;
    }

    public Weapon GetWeapon()
    {
        return weapon;
    }

    public void AssignWeapon(Weapon assignedWeapon)
    {
        this.weapon = assignedWeapon;
    }
}