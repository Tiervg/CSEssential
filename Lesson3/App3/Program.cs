using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//x Создать класс, представляющий учебный класс ClassRoom.
//x Создайте класс ученик Pupil.В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().  
//x Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.
//x Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
//x Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
//x Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil excelent = new ExcelentPupil();
            GoodPupil good = new GoodPupil();
            BadPupil bad = new BadPupil();
            ClassRoom classRoom = new ClassRoom(excelent,good,bad);
            classRoom.Show();
        }
    }
}
