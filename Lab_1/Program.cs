using System;

namespace oop3k
{
    class Program
    {
        static void Main(string[] args)
        {
            TTriangle triangle = new TTriangle();
            TTrianglePrizm trianglePrizm = new TTrianglePrizm();
            int choose = 0;
            bool isTriangle = false;
            int x = 0, y = 0;
            do
            {
                Console.Write("Menu.\n" +
                              "1. Triangle.\n" +
                              "2. Prizm.\n" +
                              "Enter your choose: ");
                int.TryParse(Console.ReadLine(), out choose);


                switch(choose)
                {
                    case 1:
                        {
                            Console.Write("Menu.\n" +
                              "1. Create new triangle.\n" +
                              "2. Show triangle with triangle and perimetr.\n" +
                              "3. Addition, substraction and multiply triangles.\n" +
                              "4. Exit.\n" +
                              "Enter your choose: ");
                            int.TryParse(Console.ReadLine(), out choose);
                            Console.Clear();
                            switch (choose)
                            {
                                case 1:
                                    {
                                        Console.Write("Menu.\n" +
                                                      "1. Default constructor.\n" +
                                                      "2. Constructor with parametrs.\n" +
                                                      "3. Copy constructor.\n" +
                                                      "Enter your choose: ");
                                        int.TryParse(Console.ReadLine(), out choose);

                                        switch (choose)
                                        {
                                            case 1:
                                                {
                                                    triangle = new TTriangle();
                                                    isTriangle = false;
                                                }
                                                break;
                                            case 2:
                                                {
                                                    Console.Write("Enter A X: ");
                                                    int.TryParse(Console.ReadLine(), out x);
                                                    Console.Write("Enter A Y: ");
                                                    int.TryParse(Console.ReadLine(), out y);

                                                    DPoint pointA = new DPoint(x, y);

                                                    Console.Write("Enter B X: ");
                                                    int.TryParse(Console.ReadLine(), out x);
                                                    Console.Write("Enter B Y: ");
                                                    int.TryParse(Console.ReadLine(), out y);

                                                    DPoint pointB = new DPoint(x, y);

                                                    Console.Write("Enter C X: ");
                                                    int.TryParse(Console.ReadLine(), out x);
                                                    Console.Write("Enter C Y: ");
                                                    int.TryParse(Console.ReadLine(), out y);

                                                    DPoint pointC = new DPoint(x, y);
                                                    isTriangle = true;
                                                    Side sideAB = new Side(pointA, pointB);
                                                    Side sideBC = new Side(pointB, pointC);
                                                    Side sideCA = new Side(pointC, pointA);
                                                    try
                                                    {
                                                        triangle = new TTriangle(sideAB, sideBC, sideCA);
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine(e.Message);
                                                        isTriangle = false;
                                                    }
                                                    finally
                                                    {
                                                        Console.WriteLine("Triangle was created!");
                                                    }


                                                }
                                                break;
                                            case 3:
                                                {
                                                    Console.WriteLine("Create triangle for copy!");

                                                    Console.Write("Enter A X: ");
                                                    int.TryParse(Console.ReadLine(), out x);
                                                    Console.Write("Enter A Y: ");
                                                    int.TryParse(Console.ReadLine(), out y);

                                                    DPoint pointA = new DPoint(x, y);

                                                    Console.Write("Enter B X: ");
                                                    int.TryParse(Console.ReadLine(), out x);
                                                    Console.Write("Enter B Y: ");
                                                    int.TryParse(Console.ReadLine(), out y);

                                                    DPoint pointB = new DPoint(x, y);

                                                    Console.Write("Enter C X: ");
                                                    int.TryParse(Console.ReadLine(), out x);
                                                    Console.Write("Enter C Y: ");
                                                    int.TryParse(Console.ReadLine(), out y);

                                                    DPoint pointC = new DPoint(x, y);

                                                    Side sideAB = new Side(pointA, pointB);
                                                    Side sideBC = new Side(pointB, pointC);
                                                    Side sideCA = new Side(pointC, pointA);
                                                    isTriangle = true;
                                                    TTriangle copyTriangle = null;
                                                    try
                                                    {
                                                        copyTriangle = new TTriangle(sideAB, sideBC, sideCA);
                                                        triangle = new TTriangle(copyTriangle);
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        isTriangle = false;
                                                        Console.WriteLine(e.Message);
                                                    }
                                                    finally
                                                    {
                                                        Console.WriteLine("Triangle was created!");
                                                    }
                                                }
                                                break;
                                            default:
                                                {
                                                    Console.WriteLine("Something wrong.");
                                                }
                                                break;
                                        }
                                    }
                                    break;

                                case 2:
                                    {
                                        if (isTriangle)
                                        {
                                            triangle.Show();
                                        }
                                        else Console.WriteLine("First create an explicit triangle!");
                                    }
                                    break;
                                case 3:
                                    {
                                        if (!isTriangle)
                                        {
                                            Console.WriteLine("First create an explicit triangle!");
                                            break;
                                        }
                                        Console.Write("Enter A X: ");
                                        int.TryParse(Console.ReadLine(), out x);
                                        Console.Write("Enter A Y: ");
                                        int.TryParse(Console.ReadLine(), out y);

                                        DPoint pointA = new DPoint(x, y);

                                        Console.Write("Enter B X: ");
                                        int.TryParse(Console.ReadLine(), out x);
                                        Console.Write("Enter B Y: ");
                                        int.TryParse(Console.ReadLine(), out y);

                                        DPoint pointB = new DPoint(x, y);

                                        Console.Write("Enter C X: ");
                                        int.TryParse(Console.ReadLine(), out x);
                                        Console.Write("Enter C Y: ");
                                        int.TryParse(Console.ReadLine(), out y);

                                        DPoint pointC = new DPoint(x, y);


                                        isTriangle = true;
                                        Side sideAB = new Side(pointA, pointB);
                                        Side sideBC = new Side(pointB, pointC);
                                        Side sideCA = new Side(pointC, pointA);
                                        TTriangle secondTriangle = null;
                                        try
                                        {
                                            secondTriangle = new TTriangle(sideAB, sideBC, sideCA);
                                        }
                                        catch (Exception e)
                                        {
                                            Console.WriteLine(e.Message);
                                            break;
                                        }
                                        finally
                                        {
                                            Console.WriteLine("Triangle was created!");
                                        }


                                        Console.WriteLine($"Is first triangle equals to second: {triangle == secondTriangle}");

                                        try
                                        {


                                            TTriangle resultTriangle = triangle + secondTriangle;
                                            Console.WriteLine("Result of addiction:");
                                            resultTriangle.Show();
                                            Console.WriteLine();


                                            resultTriangle = triangle - secondTriangle;
                                            Console.WriteLine("Result of substraction:");
                                            resultTriangle.Show();
                                            Console.WriteLine();

                                            Console.WriteLine("Enter number: ");
                                            int number = int.Parse(Console.ReadLine());

                                            resultTriangle = triangle * number;
                                            Console.WriteLine($"Result of multiply first triangle on {number}:");
                                            resultTriangle.Show();
                                        }
                                        catch (Exception e)
                                        {
                                            Console.WriteLine(e.Message);
                                        }
                                        finally
                                        {
                                            Console.WriteLine("Thats all result!");
                                        }
                                    }
                                    break;
                                case 4:
                                    {
                                        Console.WriteLine("Close the program..");
                                        Environment.Exit(0);
                                    }
                                    break;
                                default:
                                    {
                                        Console.WriteLine("Something wrong!");
                                    }
                                    break;
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Enter A X: ");
                            int.TryParse(Console.ReadLine(), out x);
                            Console.Write("Enter A Y: ");
                            int.TryParse(Console.ReadLine(), out y);

                            DPoint pointA = new DPoint(x, y);

                            Console.Write("Enter B X: ");
                            int.TryParse(Console.ReadLine(), out x);
                            Console.Write("Enter B Y: ");
                            int.TryParse(Console.ReadLine(), out y);

                            DPoint pointB = new DPoint(x, y);

                            Console.Write("Enter C X: ");
                            int.TryParse(Console.ReadLine(), out x);
                            Console.Write("Enter C Y: ");
                            int.TryParse(Console.ReadLine(), out y);

                            DPoint pointC = new DPoint(x, y);

                            Side sideAB = new Side(pointA, pointB);
                            Side sideBC = new Side(pointB, pointC);
                            Side sideCA = new Side(pointC, pointA);

                            Console.Write("Enter H: ");
                            double.TryParse(Console.ReadLine(), out double h);
                            try
                            {
                                TTriangle tempTriangle = new TTriangle(sideAB, sideBC, sideCA);
                                trianglePrizm = new TTrianglePrizm(tempTriangle, h);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                break;
                            }
                            finally
                            {
                                Console.WriteLine("Prizm was created!");
                            }



                            Console.WriteLine("Volume: " + trianglePrizm.GetSquare() + " / "
                                + Math.Round(trianglePrizm.GetSquare(), 2));


                        }
                        break;
                }

            } while (true);

        }
    }
}

