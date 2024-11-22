C# Port Scanner
Description
This C# script demonstrates a simple port scanner that checks the availability of ports on a specified host. It takes the hostname and a range of ports as input, then attempts to connect to each port within the specified range, printing whether the port is open or closed.

Requirements
.NET Framework or .NET Core

git clone [https://github.com/your-username/your-repo-name.git](https://github.com/HackingHusky/port-scanner)
cd where you want to put it

Remember, its a C lauange. 

A C# compiler


How to Use
Build and run the project in your IDE.

Execute the program with the desired hostname and port range. For example:

PortScanner.exe 127.0.0.1 20 80
Key Features:
Hostname and Port Range as Arguments: The program accepts the target hostname and port range as command-line arguments.

Port Scanning Logic: The ScanPort method attempts to connect to each port within the specified range using a TcpClient.

Exception Handling: Socket exceptions are caught to determine if the port is closed.

This simple port scanner will help you check the availability of ports on a specified host. Use this tool responsibly and ensure you have the necessary permissions to scan the target host.

Notes
Ensure you have the necessary permissions to scan the target host.

This script is for educational purposes only. Unauthorized port scanning can be illegal and unethical.

License
This project is licensed under the MIT License. See the LICENSE file for details.

Acknowledgements
System.Net.Sockets for handling TCP connections.
