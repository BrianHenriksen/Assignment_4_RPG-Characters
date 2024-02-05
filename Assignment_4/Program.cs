using Assignment_4.Character_classes;
using Assignment_4.Weapons;

namespace Assignment_4;

class Program
{
    static void Main(string[] args)
    {
        List<Character_class> characters = [];

        Knight anri = new Knight("Anri", "Knight of Astora");
        Herald patches = new Herald("Patches", "The Unbreakable");
        Sorcerer orbeck = new Sorcerer("Orbeck", "Sorcerer of Vinheim");
        Pyromancer cornyx = new Pyromancer("Cornyx", "Flame of the Great Swamp");

        SunlightStraightSword sunSword = new SunlightStraightSword();
        WingedSpear spear = new WingedSpear();
        SorcererStaff staff = new SorcererStaff();
        PyromancyFlame flame = new PyromancyFlame();
        
        anri.AssignWeapon(sunSword);
        patches.AssignWeapon(spear);
        orbeck.AssignWeapon(staff);
        cornyx.AssignWeapon(flame);
        
        characters.Add(anri);
        characters.Add(patches);
        characters.Add(orbeck);
        characters.Add(cornyx);
        
        foreach (var character in characters)
        {
            Console.WriteLine($"{character.GetName()} is equipped with the {character.GetWeapon()?.GetWeaponName()}" +
                              $" and uses weapon-skill: {character.GetWeapon()?.GetWeaponSkill()}");
        }

        Console.ReadKey();
    }
}