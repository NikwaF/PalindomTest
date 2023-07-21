while (true)
{
    Console.WriteLine("masukan kata");
    Console.Write("inputan: ");
    string kataKata = Console.ReadLine();
    bool isPalindom = kataKata.SequenceEqual(kataKata.Reverse());
    Console.WriteLine(string.Format("apakah dia adalah palindom ? {0}", isPalindom));
    Console.WriteLine("====================================");
}
