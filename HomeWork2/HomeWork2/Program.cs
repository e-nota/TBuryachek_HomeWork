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
            Console.WriteLine($"figure: NumberOfFaces = {figurestr.NumberOfFaces}, LengthOfFaces = {figurestr.LengthOfFaces}, Area = {figurestr.Area}");
            Console.WriteLine($"NewAreaFigure: NumberOfFaces = {NewAreaFigureStr.NumberOfFaces}, LengthOfFaces = {NewAreaFigureStr.LengthOfFaces}, Area = {NewAreaFigureStr.Area}");

            CalcArea2(figurestr);
            Console.WriteLine($"NumberOfFaces = {figurestr.NumberOfFaces}, LengthOfFaces = {figurestr.LengthOfFaces}, Area = {figurestr.Area}");

        }
        public static Figure CalcArea1 (Figure figure)
        {
            figure = new Figure() { NumberOfFaces = 4, LengthOfFaces = 4, Area = FormulaS(figure.NumberOfFaces, figure.LengthOfFaces)}; 
            return figure;
         }

        public static void CalcArea2 (Figure figure)
        {
             figure.Area = FormulaS(figure.NumberOfFaces, figure.LengthOfFaces);
        }
//---
        public static FigureStruct CalcArea1(FigureStruct figurestr)
        {
            figurestr = new FigureStruct()  { NumberOfFaces = 4, LengthOfFaces = 4, Area = FormulaS(figurestr.NumberOfFaces, figurestr.LengthOfFaces) }; 
            return figurestr;
        }

        public static void CalcArea2(FigureStruct figurestr)
        {
         
            figurestr.Area = FormulaS(figurestr.NumberOfFaces, figurestr.LengthOfFaces);
        }

        public static double FormulaS(int n, double a) 
        {
            double S = (n * Math.Pow(a, 2)) / (4 * Math.Round(Math.Tan((180 / n) * (Math.PI / 180)), 4));
            return S;
        }

    }
}
