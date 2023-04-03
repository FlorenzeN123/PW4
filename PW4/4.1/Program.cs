namespace PW4
{
    // Класс Заклинание
    class Spell
    {
        // Свойства
        public int Mana { get; private set; }
        public string Effect { get; set; }
        public string Name { get; set; }
        // Конструктор
        public Spell(string name, int mana, string effect)
        {
            Name = name;
            Mana = mana;
            Effect = effect;
        }
        // Метод использования заклинания
        public void Use(Magician magician)
        {
            Console.WriteLine($"{magician.Name} превращение! {Effect}");
        }
    }

    // Класс Волшебник
    class Magician
    {
        // Свойства
        public string Name { get; private set; }
        public int Mana { get; private set; }
        // Конструктор
        public Magician(string name, int mana)
        {
            Name = name;
            Mana = mana;
        }
        // Метод каста заклинания
        public void CastSpell(Spell spell)
        {
            if (Mana >= spell.Mana)
            {
                spell.Use(this);
                Mana -= spell.Mana;
            }
            else
            {
                Console.WriteLine($"Для использования {spell.Name} не хватает {spell.Mana - Mana} единиц маны. Хлебните салву!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Экземпляры Заклинаний
            Spell alohomora = new Spell("Алохомора", 60, "Хекс");
            Spell vingardiumLeviosa = new Spell("Вингардиум Левиоса", 60, "Предмет превратиться в лягушку!");

            // Экземпляр Волшебника
            Magician garryPotter = new Magician("Лион", 100);

            garryPotter.CastSpell(alohomora);
            garryPotter.CastSpell(vingardiumLeviosa);

            Console.ReadKey(true);
        }
    }
}