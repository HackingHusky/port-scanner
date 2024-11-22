using System;
using System.Net.Sockets;

class PortScanner
{
    static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("Usage: PortScanner <hostname> <startPort> <endPort>");
            return;
        }

        string hostname = args[0];
        int startPort = int.Parse(args[1]);
        int endPort = int.Parse(args[2]);

        Console.WriteLine($"Scanning ports from {startPort} to {endPort} on {hostname}...");

        for (int port = startPort; port <= endPort; port++)
        {
            ScanPort(hostname, port);
        }

        Console.WriteLine("Port scanning completed.");
    }

    static void ScanPort(string hostname, int port)
    {
        using (TcpClient tcpClient = new TcpClient())
        {
            try
            {
                tcpClient.Connect(hostname, port);
                Console.WriteLine($"Port {port} is open.");
            }
            catch (SocketException)
            {
                Console.WriteLine($"Port {port} is closed.");
            }
        }
    }
}
