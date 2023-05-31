using System;

using System.IO;



class Program

{

    static void Main()

    {

        Console.WriteLine("Sisesta tekst: ");

        string tekst = Console.ReadLine();



        try

        {

            string soovitudKoht = "C:\\Teekond\\fail.txt"; // asenda see sobiva failiteega

            SalvestaFaili(tekst, soovitudKoht);

            Console.WriteLine("Tekst salvestatud õigesse kohta.");

        }

        catch (Exception ex)

        {

            Console.WriteLine("Tekst ei saanud salvestada õigesse kohta: " + ex.Message);

        }



        try

        {

            string valeKoht = "C:\\Vale\\koht\\fail.txt"; // asenda see sobiva failiteega

            SalvestaFaili(tekst, valeKoht);

            Console.WriteLine("Tekst salvestatud valesse kohta.");

        }

        catch (Exception ex)

        {

            Console.WriteLine("Tekst ei saanud salvestada valesse kohta: " + ex.Message);

        }



        // Numbri püramiidi loomine

        for (int i = 1; i <= 6; i++)

        {

            for (int j = 1; j <= i; j++)

            {

                Console.Write(i + " ");

            }

            Console.WriteLine();

        }



        Console.WriteLine("Hello, World!");

    }



    static void SalvestaFaili(string tekst, string failiTee)

    {

        File.WriteAllText(failiTee, tekst);

    }

}
