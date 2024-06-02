namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Подготовка к бою");
            Console.WriteLine("Введите имя бойца");
            
            var nameFighter = Console.ReadLine();
            Console.WriteLine("Имя бойца - {0}",nameFighter);
            
            Console.WriteLine("Введите начальное здоровье бойца (10-100)");
            if (!float.TryParse(Console.ReadLine(), out float healthFighter))
            {
                Console.WriteLine("Введенное число не float");
                return;
            }
            if (healthFighter < 10 || healthFighter > 100)
            {
                Console.WriteLine("Введенное число не в диапазоне значений 10-100");
                return;
            }
            Console.WriteLine("Начальное здоровье бойца - {0}", healthFighter);

            
            Console.WriteLine("Введите значение брони шлема от 0, до 1:");
            if (!float.TryParse(Console.ReadLine(), out float armorHelm))
            {
                Console.WriteLine("Введенное число не float");
                return;
            }
            if (armorHelm < 0 || armorHelm > 1)
            {
                Console.WriteLine("Введенное число не в диапазоне значений 0-1");
                return;
            }
            var fighterArmorHelm = new Helm("Helm");
            fighterArmorHelm.ArmorHelm = armorHelm;
            Console.WriteLine("Значение брони шлема - {0}", armorHelm);

            Console.WriteLine("Введите значение брони кирасы от 0, до 1");
            if (!float.TryParse(Console.ReadLine(), out float armorShell))
            {
                Console.WriteLine("Введенное число не float");
                return;
            }
            if (armorShell < 0 || armorShell > 1)
            {
                Console.WriteLine("Введенное число не в диапазоне значений 0-1");
                return;
            }
            var fighterArmorShell = new Shell("Shell");
            fighterArmorShell.ArmorShell = armorShell;
            Console.WriteLine("Значение брони кирасы - {0}", armorShell);

            Console.WriteLine("Введите значение брони сапог от 0, до 1");
            if (!float.TryParse(Console.ReadLine(), out float armorBoots))
            {
                Console.WriteLine("Введенное число не float");
                return;
            }
            if (armorBoots < 0 || armorBoots > 1)
            {
                Console.WriteLine("Введенное число не в диапазоне значений 0-1");
                return;
            }
            var fighterArmorBoots = new Boots("Boots");
            fighterArmorBoots.ArmorBoots = armorBoots;
            Console.WriteLine("Значение брони сапог - {0}", armorBoots);

            Console.WriteLine("Укажите минимальный урон оружия (0-20)");
            if (!float.TryParse(Console.ReadLine(), out float minDamageWeaponFighter))
            {
                Console.WriteLine("Введенное число не float");
                return;
            }
            if (minDamageWeaponFighter < 0 || minDamageWeaponFighter > 20)
            {
                Console.WriteLine("Введенное число не в диапазоне значений 0-20");
                return;
            }
            Console.WriteLine("Минимальный урон оружия - {0}", minDamageWeaponFighter);

            Console.WriteLine("Укажите максимальный урон оружия (20-40)");
            if (!float.TryParse(Console.ReadLine(), out float maxDamageWeaponFighter))
            {
                Console.WriteLine("Введенное число не float");
                return;
            }
            if (maxDamageWeaponFighter < 20 || maxDamageWeaponFighter > 40)
            {
                Console.WriteLine("Введенное число не в диапазоне значений 20-40");
                return;
            }
            Console.WriteLine("Максимальный урон оружия - {0}", maxDamageWeaponFighter);
            var fighterWeapon = new Weapon("Weapon",minDamageWeaponFighter,maxDamageWeaponFighter);

            var unitFighter = new Unit(nameFighter);

            Console.WriteLine("Общий показатель брони равен: {0}", unitFighter.Armor);
            Console.WriteLine("Фактическое значение здоровья равно: {0}", unitFighter.RealHealth());

        }
    }
}