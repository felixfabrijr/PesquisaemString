using System;

public class Program
{
    public static void Main()
    {
        string letraMusica = "you said goodbye, and I say hello!";
        //Console.WriteLine(letraMusica.Contains("goodbye"));
        //Console.WriteLine(letraMusica.Contains("love)"));

        //Console.WriteLine(letraMusica.StartsWith("you"));
        //Console.WriteLine(letraMusica.StartsWith("goodbye"));

        //Console.WriteLine(letraMusica.Contains("goodbye"));
        //Console.WriteLine(letraMusica.Contains("love"));

        //Console.WriteLine(letraMusica.StartsWith("love"));
        //Console.WriteLine(letraMusica.StartsWith("you"));

        //Console.WriteLine(letraMusica.EndsWith("say"));
        //Console.WriteLine(letraMusica.EndsWith("you"));

        //bool comecaComVoce = letraMusica.StartsWith("you");
        //Console.WriteLine(comecaComVoce);

        Console.WriteLine(letraMusica.IndexOf("goodbye"));



    }
}