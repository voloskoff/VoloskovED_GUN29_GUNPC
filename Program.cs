namespace Classes
{

    //class Test
    //{
        
    //    public int Field = 50;
    //    private float property;
    //    public float Property
    //    {
    //        get
    //        {
    //            if (property == 0f)
    //            {
    //                return 1f;
    //            }
    //            return property;
    //        }
    //        private set
    //        {
    //            if (property < 0f)
    //            {
    //                Console.WriteLine("Trying to set negative value to property");
    //                return;
    //            }
    //            property = value;
    //        }
    //    }

    //    public void SomeMetod1(int number)
    //    {
    //        Console.WriteLine("Metod 1 works " + number);
    //    }
    //    public Char SomeMetod2(char someChar)
    //    {
    //        if (someChar == 'a')
    //        {
    //            return 'b';
    //        }
    //        return 'c';
    //    }
    //    public Test()
    //    {
    //        Property = 10f;
    //    }

    //    public Test(int number) => Field = number;

    //    public Test(float number)
    //    {
    //        Property = number;
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Подготовка к бою");
            Console.WriteLine("Введите имя бойца");
            
            //var nameFighter = new Unit(Console.ReadLine());
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
            //var armorHelmTMP = new Helm();
            //armorHelmTMP.ArmorHelm = armorHelm;
            Console.WriteLine("Значение брони шлема - {0}", armorHelm);
           

            //Console.WriteLine("Введите значение брони кирасы от 0, до 1");
            //if (!float.TryParse(Console.ReadLine(), out float armorCuirass))
            //{
            //    Console.WriteLine("Введенное число не float");
            //    return;
            //}
            //if (armorCuirass < 0 || armorCuirass > 1)
            //{
            //    Console.WriteLine("Введенное число не в диапазоне значений 0-1");
            //    return;
            //}
            //Console.WriteLine("Значение брони кирасы - {0}", armorCuirass);

            //Console.WriteLine("Введите значение брони сапог от 0, до 1");
            //if (!float.TryParse(Console.ReadLine(), out float armorBoots))
            //{
            //    Console.WriteLine("Введенное число не float");
            //    return;
            //}
            //if (armorBoots < 0 || armorBoots > 1)
            //{
            //    Console.WriteLine("Введенное число не в диапазоне значений 0-1");
            //    return;
            //}
            //Console.WriteLine("Значение брони сапог - {0}", armorBoots);

            //Console.WriteLine("Укажите минимальный урон оружия (0-20)");
            //if (!float.TryParse(Console.ReadLine(), out float minDamageWeaponFighter))
            //{
            //    Console.WriteLine("Введенное число не float");
            //    return;
            //}
            //if (minDamageWeaponFighter < 0 || minDamageWeaponFighter > 20)
            //{
            //    Console.WriteLine("Введенное число не в диапазоне значений 0-20");
            //    return;
            //}
            //Console.WriteLine("Минимальный урон оружия - {0}", minDamageWeaponFighter);

            //Console.WriteLine("Укажите максимальный урон оружия (20-40)");
            //if (!float.TryParse(Console.ReadLine(), out float maxDamageWeaponFighter))
            //{
            //    Console.WriteLine("Введенное число не float");
            //    return;
            //}
            //if (maxDamageWeaponFighter < 20 || maxDamageWeaponFighter > 40)
            //{
            //    Console.WriteLine("Введенное число не в диапазоне значений 20-40");
            //    return;
            //}
            //Console.WriteLine("Максимальный урон оружия - {0}", maxDamageWeaponFighter);

            var unitFighter = new Unit(nameFighter);
            Console.WriteLine(unitFighter.Armor);

            Console.WriteLine("Общий показатель брони равен: ");


            Console.WriteLine("Фактическое значение здоровья равно: ");

            var object1 = new Unit();
            //var object2 = new Test(789);
            //var object3 = new Test(5678.123f);

            Console.WriteLine(object1.Name);


            //Console.WriteLine("object 1 field value = {0} and object 2 = {1}", object2.Field, object2.Field);
            //Console.WriteLine("object 1 field value = {0} and object 2 = {1}", object2.Property, object3.Property);

        }
    }
}