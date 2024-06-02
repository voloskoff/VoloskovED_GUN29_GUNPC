namespace Classes
{
    internal class Unit
    {
        private float _health;
        private float _baseDamage = 5f;

        public string Name { get; } 
        public float Health { get { return _health; } }
        public float Damage
        {
            get 
            {
                Weapon weapon = new Weapon("FighterWeapon");
                return weapon.Damage + _baseDamage; 
            }
        } 

        public float Armor
        {
            get 
            {
                Helm armorHelm = new Helm("FighterArmorHelm");
                Shell armorShell = new Shell("FighterArmorShell");
                Boots armorBoots = new Boots ("FighterArmorBoots");
                //var armor = armorHelm.ArmorHelm + armorShell.ArmorShell + armorBoots.ArmorBoots;
                //if (armor < 0) armor = 0;
                //if (armor >=1) armor = 1;
                //return armor;
                return armorHelm.ArmorHelm + armorShell.ArmorShell + armorBoots.ArmorBoots; ;
            }
        }

        public Unit() : this("Unknown Unit")
        {

        }
        public Unit(string unitName)
        {
            Name = unitName;
        }

        public float RealHealth()
        {
            _health = Health * (1f + Armor);
            Console.WriteLine("Здоровье Юнита щас",Health);
            return Health;
        }
        private bool SetDamage()
        {

            _health = Health - Damage * Armor;
            if (_health <= 0f)
            {
                Console.WriteLine("Здоровье Юнита меньше 0");
                return true;
            }
            else
            {
                return false;
            }
        }
        public void EquipWeapon(Weapon weapon)
        {

        }
        public void EquipHelm(Helm helm)
        {

        }
        public void EquipShell(Shell shell)
        {

        }
        public void EquipBoots(Boots boots)
        {

        }
       
    }
}
