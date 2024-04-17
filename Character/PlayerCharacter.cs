class PlayerCharacter
{
    // Default selections of stats and skills this will change through CC phase then again through lvlup
    
    public string name;
    
    public enum playerRace {Nothing, Human, Orc, Elf, Dwarf};
    public playerRace currentRace = playerRace.Nothing;

    public enum playerClass {Peasant, Mage, Warrior, Thief, Hunter};
    public playerClass currentClass = playerClass.Peasant;

    public string diety;
  
    public int health = 10; 
    public int mana = 10; 
    public int gold = 0; 
    public int experience = 0;
    public int armorClass = 0; 
    public int spellSlots = 0; 
    public int healthPots = 0; 
    public int weaponDamage = 0; 
    public int bagSpace = 0; 
 
    public int level = 1;
    public int skill_Acrobatics = 0; 
    public int skill_Agility = 0;  
    public int skill_Charisma = 0; 
    public int skill_Dexterity = 0;
    public int skill_Intelligence = 0; 
    public int skill_Perception = 0; 
    public int skill_Strength = 0;
    public int skill_Wisdom = 0;

    public string weaponEquiped;


    // Setters
    
}