namespace Classes
{
    internal class Unit
    {
        private float _health;
        //private float _damage = 5f;
        private float _baseDamage = 5f;

        public string Name { get; } /*= "Unknown Unit";*/
        public float Health { get { return _health; } }
        public float Damage
        {
            get 
            { 

                return _baseDamage; 
            }
            
        } 

        public float Armor
        {
            get 
            {
                Helm armorHelm = new Helm("FighterArmorHelm");
                Shell armorShell = new Shell("FighterArmorShell");
                Boots armorBoots = new Boots ("FighterArmorBoots");
                var armor = armorHelm.ArmorHelm + armorShell.ArmorShell + armorBoots.ArmorBoots;
                if (armor < 0) armor = 0;
                if (armor >=1) armor = 1;
                return armor ;
            }
          
        }


        public Unit() : this("Unknown Unit")
        {

        }
        public Unit(string unitName)
        {
            Name = unitName;
        }

        private float RealHealth()
        {
            return Health;//дописать выражение Health * (1f + Armor)
        }
        private bool SetDamage()
        {
            //рассчет ХП
            //Health - value * Armor
            if (Health <= 0f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void EquipWeapon()// дописать принимаемый аргумент
        {

        }
        private void EquipArmor()
        {

        }
        private void EquipHelm()// дописать принимаемый аргумент
        {

        }
        private void EquipShell()// дописать принимаемый аргумент
        {

        }
        private void EquipBoots()// дописать принимаемый аргумент
        {

        }
       
    }
}
