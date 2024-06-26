﻿//Вариант 1, задание 2

using System;

namespace ConsoleApp1
{
    public abstract class Professdion
    {
        protected string _Name;
        protected int _Bonus;
        public abstract int Money();
        public Professdion(string Name, int Bpnus)
        {
            _Name = Name;
            _Bonus = Bpnus;
        }
        public string name { get { return _Name; } }
        public virtual void Print()
        {
            System.Console.WriteLine(($"Название: {_Name}\t Надбавка: {_Bonus}\t"));
        }
    }
    class Fireman : Professdion
    {
        private int _Danger;
        public Fireman(string Name, int Bpnus, int Danger) : base(Name, Bpnus)
        {
            _Danger = Danger;
        }
        public override int Money()
        {
            return _Bonus * _Danger;
        }
        public override void Print()
        {
            System.Console.WriteLine(($"Название: {_Name}\t Надбавка: {_Bonus}\t Зарплата: {Money()}"));
        }
    }

    class Engineer : Professdion
    {
        private int _Category;
        public Engineer(string Name, int Bpnus, int Category) : base(Name, Bpnus)
        {
            _Category = Category;
        }
        public override int Money()
        {
            return _Bonus * _Category;
        }
        public override void Print()
        {
            System.Console.WriteLine(($"Название: {_Name}\t Надбавка: {_Bonus}\t Зарплата: {Money()}"));
        }
    }

    class Scientist : Professdion
    {
        private int _Degree;
        public Scientist(string Name, int Bpnus, int Degree) : base(Name, Bpnus)
        {
            _Degree = Degree;
        }
        public override int Money()
        {
            return _Bonus * _Degree;
        }
        public override void Print()
        {
            System.Console.WriteLine(($"Название: {_Name}\t Надбавка: {_Bonus}\t Зарплата: {Money()}"));
        }
    }
    internal class Program
    {
        static void Sort(Professdion[] ARRAY)
        {
            for(int i=1;i<ARRAY.Length;i++)
            {
                for(int j=1;j<ARRAY.Length;j++)
                {
                    if (ARRAY[j - 1].Money() < ARRAY[j].Money())
                    {
                        Professdion p = ARRAY[j];
                        ARRAY[j] = ARRAY[j - 1];
                        ARRAY[j-1] = p;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Fireman[] array1 = new Fireman[5];
            array1[0] = new Fireman("Пожарный0", 10, 10);
            array1[1] = new Fireman("Пожарный1", 12, 10);
            array1[2] = new Fireman("Пожарный2", 13, 10);
            array1[3] = new Fireman("Пожарный3", 14, 10);
            array1[4] = new Fireman("Пожарный4", 15, 10);
            Sort(array1);
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i].Print();
            }
            System.Console.WriteLine();

            Scientist[] array2 = new Scientist[5];
            array2[0] = new Scientist("Ученый0", 10, 10);
            array2[1] = new Scientist("Ученый1", 12, 10);
            array2[2] = new Scientist("Ученый2", 13, 10);
            array2[3] = new Scientist("Ученый3", 15, 10);
            array2[4] = new Scientist("Ученый4", 16, 10);
            Sort(array2);
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i].Print();
            }
            System.Console.WriteLine();

            Engineer[] array3 = new Engineer[5];
            array3[0] = new Engineer("Инжинер0", 17, 10);
            array3[1] = new Engineer("Инжинер1", 18, 10);
            array3[2] = new Engineer("Инжинер2", 19, 10);
            array3[3] = new Engineer("Инжинер3", 14, 10);
            array3[4] = new Engineer("Инжинер4", 12, 10);
            Sort(array3);
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i].Print();
            }

            Console.WriteLine();
            Console.WriteLine("ОбЪединенный массив");
            int size = array1.Length + array2.Length + array3.Length;
            Professdion[] array4 = new Professdion[size];
            int g = 0;
            for (int i=0;i<array1.Length;i++)
            {
                array4[i] = array1[i];
                g = i;
            }
            for (int i = 0; i < (array1.Length); i++)
            {
                array4[g] = array2[i];
                g++;
            }
            for (int i = 0; i < (array1.Length); i++)
            {
                array4[g] = array3[i];
                g++;
            }

            for(int i=0;i<array4.Length;i++)
            {
                array4[i].Print();
            }

        }
    }
}

