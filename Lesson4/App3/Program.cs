using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//todo Создайте 2 интерфейса IPlayable и IRecodable.В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно. 
//todo Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
//Написать программу, которая выполняет проигрывание и запись.

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player sony = new Player();
            sony.Record();
            sony.Pause();
            IRecordable recSony = sony as IRecordable;
            recSony.Stop();
            IPlayable playSony = sony as IPlayable;
            playSony.Play();
            playSony.Pause();
            playSony.Stop();
        }
    }
}
