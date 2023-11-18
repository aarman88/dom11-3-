using System;

public enum Food
{
    Рыба,
    Мышка,
    Молоко
}

public class Cat
{
    private int hungerLevel;  // Уровень сытости

    public Cat()
    {
        hungerLevel = 0;  // Изначально кошка не голодна
    }

    public int HungerLevel
    {
        get { return hungerLevel; }
    }

    public void Eat(Food food)
    {
        switch (food)
        {
            case Food.Рыба:
                hungerLevel += 3;  // Уровень сытости увеличивается при поедании рыбы
                break;
            case Food.Мышка:
                hungerLevel += 2;  // Уровень сытости увеличивается при поедании мыши
                break;
            case Food.Молоко:
                hungerLevel += 1;  // Уровень сытости увеличивается при поедании молока
                break;
            default:
                Console.WriteLine("Неизвестная еда");
                break;
        }

        Console.WriteLine($"Кошка поела {food}. Уровень сытости: {hungerLevel}");
    }
}

class Program
{
    static void Main()
    {
        Cat cat = new Cat();

        cat.Eat(Food.Рыба);  // Кормим кошку рыбой
        cat.Eat(Food.Мышка); // Кормим кошку мышью
        cat.Eat(Food.Молоко);  // Кормим кошку молоком

        // Можете добавить еще случаев использования
    }
}
