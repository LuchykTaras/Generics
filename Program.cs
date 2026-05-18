//// Task 1

//using System;
//using System.Collections.Generic;

//namespace OceanariumApp
//{
//    // Базовий клас для всіх мешканців океанаріуму
//    public abstract class MarineCreature
//    {
//        public string Name { get; set; }
//        public string Species { get; set; }
//        public int Age { get; set; } // в роках

//        protected MarineCreature(string name, string species, int age)
//        {
//            Name = name;
//            Species = species;
//            Age = age;
//        }

//        // Абстрактний метод для виведення унікальної інформації про істоту
//        public abstract void DisplayInfo();
//    }

//    // Клас "Акула"
//    public class Shark : MarineCreature
//    {
//        public double SwimmingSpeed { get; set; } // швидкість в км/год
//        public bool IsDangerousToHumans { get; set; }

//        public Shark(string name, string species, int age, double swimmingSpeed, bool isDangerousToHumans)
//            : base(name, species, age)
//        {
//            SwimmingSpeed = swimmingSpeed;
//            IsDangerousToHumans = isDangerousToHumans;
//        }

//        public override void DisplayInfo()
//        {
//            Console.WriteLine($"[Акула] Ім'я: {Name} | Вид: {Species} | Вік: {Age} р. | Швидкість: {SwimmingSpeed} км/год | Небезпечна для людей: {(IsDangerousToHumans ? "Так" : "Ні")}");
//        }
//    }

//    // Клас "Дельфін"
//    public class Dolphin : MarineCreature
//    {
//        public int IntelligenceScore { get; set; } // умовний показник інтелекту
//        public bool CanPerformTricks { get; set; }

//        public Dolphin(string name, string species, int age, int intelligenceScore, bool canPerformTricks)
//            : base(name, species, age)
//        {
//            IntelligenceScore = intelligenceScore;
//            CanPerformTricks = canPerformTricks;
//        }

//        public override void DisplayInfo()
//        {
//            Console.WriteLine($"[Дельфін] Ім'я: {Name} | Вид: {Species} | Вік: {Age} р. | Рівень інтелекту: {IntelligenceScore}/100 | Бере участь у шоу: {(CanPerformTricks ? "Так" : "Ні")}");
//        }
//    }

//    // Клас "Медуза"
//    public class Jellyfish : MarineCreature
//    {
//        public bool IsBioluminescent { get; set; } // чи світиться в темряві
//        public string DangerLevel { get; set; } // рівень токсичності (Низький, Середній, Смертельний)

//        public Jellyfish(string name, string species, int age, bool isBioluminescent, string dangerLevel)
//            : base(name, species, age)
//        {
//            IsBioluminescent = isBioluminescent;
//            DangerLevel = dangerLevel;
//        }

//        public override void DisplayInfo()
//        {
//            Console.WriteLine($"[Медуза] Назва: {Name} | Вид: {Species} | Вік: {Age} міс. | Світиться: {(IsBioluminescent ? "Так" : "Ні")} | Рівень небезпеки: {DangerLevel}");
//        }
//    }

//    // Клас "Океанаріум"
//    public class Oceanarium
//    {
//        public string Title { get; set; }
//        public string Location { get; set; }
//        private List<MarineCreature> inhabitants; // Список усіх мешканців

//        public Oceanarium(string title, string location)
//        {
//            Title = title;
//            Location = location;
//            inhabitants = new List<MarineCreature>();
//        }

//        // Метод для додавання нового мешканця
//        public void AddCreature(MarineCreature creature)
//        {
//            inhabitants.Add(creature);
//            Console.WriteLine($"Поповнення: {creature.Species} на ім'я {creature.Name} заселено до океанаріуму.");
//        }

//        // Метод для демонстрації всіх мешканців
//        public void ShowInhabitants()
//        {
//            Console.WriteLine($"\n--- СПИСОК МЕШКАНЦІВ ОКЕАНАРІУМУ \"{Title}\" ({Location}) ---");
//            if (inhabitants.Count == 0)
//            {
//                Console.WriteLine("Наразі океанаріум порожній.");
//                return;
//            }

//            foreach (var creature in inhabitants)
//            {
//                creature.DisplayInfo();
//            }
//            Console.WriteLine(new string('-', 60));
//        }
//    }

//    // Точка входу в програму
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Встановлюємо кодування для коректного відображення кирилиці в консолі
//            Console.OutputEncoding = System.Text.Encoding.UTF8;

//            // Створюємо об'єкт океанаріуму
//            Oceanarium oceanarium = new Oceanarium("Нептун", "Одеса");

//            Console.WriteLine("--- Створення та додавання мешканців ---");
//            // Створюємо конкретних морських істот
//            Shark shark = new Shark("Брюс", "Біла акула", 7, 45.2, true);
//            Dolphin dolphin = new Dolphin("Фліппер", "Афаліна", 4, 95, true);
//            Jellyfish jellyfish = new Jellyfish("Аурелія", "Вушаста медуза", 1, true, "Низький");

//            // Додаємо їх до списку океанаріуму
//            oceanarium.AddCreature(shark);
//            oceanarium.AddCreature(dolphin);
//            oceanarium.AddCreature(jellyfish);

//            // Виводимо повний список мешканців
//            oceanarium.ShowInhabitants();
//        }
//    }
//}