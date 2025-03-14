using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        List<string> packets = new();
        List<int> checksums = new();

        List<string> scrambledPackets = new();
        List<int> scrambledChecksums = new();
        Random random = new();
        string scrambledInput = string.Empty;

        Console.Write("Please enter your message: ");
        string userInput = Console.ReadLine() ?? string.Empty;
        packets = StringToPacket(userInput, 4);
        checksums = ChecksumGenerator(packets);

        //* Scramble the input
        foreach (char item in userInput)
        {
            if (random.Next(0, 100) < 5)
            {
                scrambledInput += (char)random.Next(0, 255);
            }
            else
            {
                scrambledInput += item;
            }
        }

        scrambledPackets = StringToPacket(scrambledInput, 4);
        scrambledChecksums = ChecksumGenerator(scrambledPackets);

        for (int i = 0; i < packets.Count; i++)
        {
            if (scrambledChecksums[i] != checksums[i])
            {
                Console.WriteLine($"[Packet {i + 1}] Data: \"{scrambledPackets[i]}\", Checksum: {checksums[i]} (Error Detected!)");
            }
            else
            {
                Console.WriteLine($"[Packet {i + 1}] Data: \"{scrambledPackets[i]}\", Checksum: {checksums[i]}");
            }
        }
    }

    private static List<string> StringToPacket(string input, int packetSize)
    {
        List<string> packets = new();
        int counter = 0;

        while (counter < input.Length)
        {
            packets.Add(input.Substring(counter, (int)MathF.Min(packetSize, input.Length - counter)));
            counter += packetSize;
        }

        return packets;
    }

    private static List<int> ChecksumGenerator(List<string> packets)
    {
        List<int> checksums = new();
        int checksum = 0;

        foreach (string item in packets)
        {
            checksum = 0;
            foreach (char thing in item)
            {
                checksum += thing;
            }
            checksums.Add(checksum % 256);
        }

        return checksums;
    }
}