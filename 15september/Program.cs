using System;

// Перечисление с флагами, представляющее возможные направления движения
[Flags]
enum Direction
{
    None = 0,  // Нет направления
    Up = 1,    // Движение вверх
    Down = 2,  // Движение вниз
    Left = 4,  // Движение влево
    Right = 8  // Движение вправо
}

// Класс, представляющий робота
class Robot
{
    private Direction currentDirection;  // Текущее направление робота

    // Конструктор класса Robot, инициализирует текущее направление как None (нет направления)
    public Robot()
    {
        currentDirection = Direction.None;
    }

    // Метод для выполнения шага в указанном направлении
    public void Move(Direction direction)
    {
        Console.WriteLine($"Шаг в направлении: {direction}");
        currentDirection |= direction;  // Добавление направления к текущему направлению с использованием операции "или"
    }

    // Метод для отображения текущего направления робота
    public void DisplayCurrentDirection()
    {
        Console.WriteLine($"Текущее направление: {currentDirection}");
    }
}

class Program
{
    // Точка входа в программу
    static void Main()
    {
        Robot robot = new Robot();  // Создание объекта робота

        // Пример последовательности шагов
        robot.Move(Direction.Up);
        robot.Move(Direction.Left);
        robot.Move(Direction.Down);
        robot.Move(Direction.Right);

        // Вывод текущего направления
        robot.DisplayCurrentDirection();
    }
}