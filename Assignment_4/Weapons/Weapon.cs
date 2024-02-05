namespace Assignment_4.Weapons;

public class Weapon
{
    protected String weaponName;
    protected String weaponDescription;
    protected String weaponSkill;

    public String GetWeaponName()
    {
        return weaponName;
    }
    
    public String GetWeaponDescription()
    {
        return weaponDescription;
    }

    public String GetWeaponSkill()
    {
        return weaponSkill;
    }
}