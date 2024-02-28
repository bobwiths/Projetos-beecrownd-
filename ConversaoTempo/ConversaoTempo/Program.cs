using System;

namespace curso{
    class Program{
        static void Main(string[] args){

            int dia1, hora1, minuto1, segundo1, dia2, hora2, minuto2, segundo2, totalDia, totalHora, totalMinuto, totalSegundo, inicioEvento, fimEvento, duracaoEvento, resto;

            Console.WriteLine("Digite o dia de inicio:");
            string[] inicio = Console.ReadLine().Split(' ');
            dia1 = int.Parse(inicio[1]);
            Console.WriteLine("Digite o horario de inicio:");
            string[] horaInicio = Console.ReadLine().Split(':');
            hora1 = int.Parse(horaInicio[0]);
            minuto1 = int.Parse(horaInicio[1]);
            segundo1 = int.Parse(horaInicio[2]);
            Console.WriteLine("Digite o dia de termino:");
            string[] termino = Console.ReadLine().Split(' ');
            dia2 = int.Parse(termino[1]);
            Console.WriteLine("Digite o horario de termino:");
            string[] horaFim = Console.ReadLine().Split(':');
            hora2 = int.Parse(horaFim[0]);
            minuto2 = int.Parse(horaFim[1]);
            segundo2 = int.Parse(horaFim[2]);

            inicioEvento = (dia1 - 1) * 24 * 60 * 60 + hora1 * 60 * 60 + minuto1 * 60 + segundo1;
            fimEvento = (dia2 - 1) * 24 * 60 * 60 + hora2 * 60 * 60 + minuto2 * 60 + segundo2;

            duracaoEvento = fimEvento - inicioEvento;

            totalDia = duracaoEvento / (24 * 60 * 60);
            resto = duracaoEvento % (24 * 60 * 60);
            totalHora = resto / (60 * 60);
            resto = resto % (60 * 60);
            totalMinuto = resto / 60;
            totalSegundo = resto % 60;

            Console.WriteLine(totalDia + " dia(s)");
            Console.WriteLine(totalHora + " hora(s)");
            Console.WriteLine(totalMinuto + " minuto(s)");
            Console.WriteLine(totalSegundo + " segundo(s)");
        }
    }
}