using System.Net.NetworkInformation;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    private static void Main(string[] args)
    {

        // --------------------------------------------------------------- MAC Adress
        //var macAddr =
        //    (
        //        from nic in NetworkInterface.GetAllNetworkInterfaces()
        //        where nic.OperationalStatus == OperationalStatus.Up
        //        select nic.GetPhysicalAddress().ToString()
        //    ).FirstOrDefault(); ;
        //Console.WriteLine(macAddr);

        var EmailId1 = Console.ReadLine();
        

        string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

        //check first string
        if (Regex.IsMatch(EmailId1, pattern))
        {
            //if email is valid
            Console.WriteLine(EmailId1 + " is a valid Email address ");
        }
        else
        {
            Console.WriteLine(EmailId1 + " is not a valid Email address");
        }
    }
}   