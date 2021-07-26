using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Класс
            Console.WriteLine("For class: ");
            Figure figure = new Figure { NumberOfFaces = 4, LengthOfFaces = 4, Area = 0 };
            
            Figure NewAreaFigure = CalcArea1(figure);
            Console.WriteLine($"figure: NumberOfFaces = {figure.NumberOfFaces}, LengthOfFaces = {figure.LengthOfFaces}, Area = {figure.Area}");
            Console.WriteLine($"NewAreaFigure: NumberOfFaces = {NewAreaFigure.NumberOfFaces}, LengthOfFaces = {NewAreaFigure.LengthOfFaces}, Area = {NewAreaFigure.Area}");

            CalcArea2(figure);
            Console.WriteLine($"NumberOfFaces = {figure.NumberOfFaces}, LengthOfFaces = {figure.LengthOfFaces}, Area = {figure.Area}");

            // Структура
            Console.WriteLine("For structure: ");
            FigureStruct figurestr = new FigureStruct { NumberOfFaces = 4, LengthOfFaces = 4, Area = 0 };

            FigureStruct NewAreaFigureStr = CalcArea1(figurestr);
            Console.WriteLine($"figure: NumberOfFaces = {figure.NumberOfFaces}, LengthOfFaces = {figure.LengthOfFaces}, Area = {figure.Area}");
            Console.WriteLine($"NewAreaFigure: NumberOfFaces = {NewAreaFigure.NumberOfFaces}, LengthOfFaces = {NewAreaFigure.LengthOfFaces}, Area = {NewAreaFigure.Area}");

            CalcArea2(figurestr);
            Console.WriteLine($"NumberOfFaces = {figure.NumberOfFaces}, LengthOfFaces = {figure.LengthOfFaces}, Area = {figure.Area}");

        }
        public static Figure CalcArea1 (Figure figure)
        {
                        
            int n = figure.NumberOfFaces;
            double a = figure.LengthOfFaces;
            double S = (n * Math.Pow(a, 2)) / (4 * Math.Tan(180 / n)); //?

            figure = new Figure() { NumberOfFaces = 4, LengthOfFaces = 4, Area = S }; //?
            
            return figure;
         }

        public static void CalcArea2 (Figure figure)
        {
            int n = figure.NumberOfFaces;
            double a = figure.LengthOfFaces;
            double S = (n * Math.Pow(a, 2)) / (4 * Math.Tan(180 / n)); //?
            figure.Area = S;
        }
//---
        public static FigureStruct CalcArea1(FigureStruct figurestr)
        {

            int n = figurestr.NumberOfFaces;
            double a = figurestr.LengthOfFaces;
            double S = (n * Math.Pow(a, 2)) / (4 * Math.Tan(180 / n)); //?

            figurestr = new FigureStruct() { NumberOfFaces = 4, LengthOfFaces = 4, Area = S }; //?

            return figurestr;
        }

        public static void CalcArea2(FigureStruct figurestr)
        {
            int n = figurestr.NumberOfFaces;
            double a = figurestr.LengthOfFaces;
            double S = (n * Math.Pow(a, 2)) / (4 * Math.Tan(180 / n)); //?
            figurestr.Area = S;
        }
    }
}
